using System;
using System.Collections.Generic;
using System.Linq;
using Commands;
using Contexto;
using FluentValidation.Results;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using webApi.Models;
using webApi.Services;
using webApi.Validators;

namespace webApi.Repository{
    public class LoginRepository {
        private ContextoDB contexto;
        public LoginRepository(IConfiguration configuration){
           this.contexto = new ContextoDB(configuration);
        }
        public ValidationLogin validaLogin(LoginFormModel dadosUser){
            ValidationLogin retorno = new ValidationLogin();
            try
            {
                var validaLogin = contexto.TabelaUsuarios.Include(r=>r.UsuarioAcesso).Where(r => r.Login == dadosUser.login && r.Senha == dadosUser.senha ).FirstOrDefault();
                if(validaLogin == null ){
                    retorno.validado = false;
                    retorno.messageErrors.Add(new string("Usuario ou senha incorretas !"));
                }else
                {
                    retorno.validado = true;
                    retorno.roles = validaLogin.UsuarioAcesso;
                    retorno.messageErrors = null;
                }              
            }
            catch(Exception e){
                throw e;
            }

            return retorno;
        }

        public RetornoGlobal<List<UsuariosModel>> GetLogin(){
            RetornoGlobal<List<UsuariosModel>> listaUsuarios = new RetornoGlobal<List<UsuariosModel>>();
            try
            {
                listaUsuarios.RetornoObjeto = contexto.TabelaUsuarios.Include(r => r.UsuarioAcesso).ToList();
                listaUsuarios.status = true;
            }
            catch(Exception e){
                listaUsuarios.status = false;
                listaUsuarios.errors.Append(e.Message);
                listaUsuarios.errors.Append(e.InnerException.ToString());
            }
            return listaUsuarios;
        }

        public RetornoGlobal<UsuariosModel> getLoginByID(int id){
            RetornoGlobal<UsuariosModel> Usuario = new RetornoGlobal<UsuariosModel>();
            try
            {
                Usuario.status = true;
                Usuario.RetornoObjeto = contexto.TabelaUsuarios.Where(f => f.Id == id).Include(r => r.UsuarioAcesso).FirstOrDefault();
            }
            catch(Exception e){
                Usuario.status = false;
                Usuario.errors.Append(e.Message);
                Usuario.errors.Append(e.InnerException.ToString());
            } 
            return Usuario;
        }

        public RetornoGlobal<UsuariosModel> postLogin(CreateLoginCommand login){

             RetornoGlobal<UsuariosModel> retorno = new RetornoGlobal<UsuariosModel>();
            try
            {
                CreateLoginValidator validator = new CreateLoginValidator(contexto);
                
                ValidationResult result = validator.Validate(login);
                if(result.IsValid)
                {
                    UsuariosModel model = new UsuariosModel();
                    model.Login = login.Login;
                    model.Senha = login.Senha;
                    model.UsuarioAcessoId = login.UsuarioAcessoId;

                    contexto.TabelaUsuarios.Add(model);
                    contexto.SaveChanges();

                    retorno.status = true;
                    retorno.RetornoObjeto =  model;
                }
                else
                {
                    retorno.status = false;
                    result.Errors.ToList().ForEach(r =>
                        retorno.errors.Add(r.ToString())
                     );
                }
            }
            catch(Exception e)
            {
               retorno.errors.Append(e.Message);
               retorno.errors.Append(e.InnerException.ToString());
               retorno.status = false;
            }
             return retorno;
        }

        public RetornoGlobal<UsuariosModel> PutLogin(UpdateLoginCommand login){

            RetornoGlobal<UsuariosModel> retorno = new RetornoGlobal<UsuariosModel>();
            try
            {
                UpdateLoginValidator validator = new UpdateLoginValidator(contexto);
                ValidationResult result = validator.Validate(login);
                if(result.IsValid)
                {
                    UsuariosModel registro  = contexto.TabelaUsuarios.Where(r=>r.Id == login.Id).First();
                    registro.Senha = login.Senha;
                    registro.UsuarioAcessoId = login.UsuarioAcessoId;
                    contexto.SaveChanges();
                    retorno.status = true;
                    retorno.RetornoObjeto = registro;
                }else
                {
                    retorno.status = false;
                    result.Errors.ToList().ForEach(r =>
                        retorno.errors.Add(r.ToString())
                     );
                }
            }
            catch(Exception e)
            {
               retorno.status = false;
               retorno.errors.Append(e.Message);
               retorno.errors.Append(e.InnerException.ToString());
            }
            return retorno;
        }

        public RetornoGlobal<UsuariosModel> DeleteLogin(int id){
            RetornoGlobal<UsuariosModel> retorno = new RetornoGlobal<UsuariosModel>();
            try
            {
                var registro = contexto.TabelaUsuarios.Where(r=>r.Id == id).FirstOrDefault();
                if(registro == null)
                {
                    retorno.status = false;
                    retorno.errors.Add("O id de usuario nao existe na tabela.");

                }
                else
                {
                    contexto.TabelaUsuarios.Remove(registro);
                    contexto.SaveChanges();
                    retorno.status = true;
                    retorno.RetornoObjeto = registro;
                }
            }
            catch(Exception e)
            {
               retorno.status = false;
               retorno.errors.Append(e.Message);
               retorno.errors.Append(e.InnerException.ToString());
            }
            return retorno;

        }

        public ValidationLogin ValidationLogin(LoginFormModel dadosUser , IConfiguration configurationGlobal){
           ValidationLogin retornoLogin = new ValidationLogin();
           ValidationResult result =  new LoginValidator().Validate(dadosUser);  
           if(result.IsValid){
              retornoLogin =  validaLogin(dadosUser);
              if(retornoLogin.validado){
                 // dadosUser.UsuarioAcesso = retornoLogin.roles;
                  TokenService tokenServiceClass = new TokenService(configurationGlobal);
                  retornoLogin.token =  tokenServiceClass.GenerateToken(dadosUser , retornoLogin.roles.DescricaoAcesso);
              }
           }
           else 
           {  
               result.Errors.ToList().ForEach(
                   f => retornoLogin.messageErrors.Add(f.ErrorMessage) 
               );
           }
            return retornoLogin;
        }
    }
}