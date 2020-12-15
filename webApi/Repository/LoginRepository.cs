using System;
using System.Collections.Generic;
using System.Linq;
using Contexto;
using Microsoft.Extensions.Configuration;
using webApi.Models;

namespace webApi.Repository{
    public class LoginRepository {
        private ContextoDB contexto;
        public LoginRepository(IConfiguration configuration){
             this.contexto = new ContextoDB(configuration);
        }
        public ValidationLogin validaLogin(LoginModel dadosUser){
            ValidationLogin retorno = new ValidationLogin();
            try
            {
                var validaLogin = contexto.TabelaUsuarios.Where(r => r.login == dadosUser.login && r.senha == dadosUser.senha ).FirstOrDefault();
                if(validaLogin == null ){
                    retorno.validado = false;
                    retorno.messageErrors.Add(new string("Usuario ou senha incorretas !"));
                }else
                {
                    retorno.validado = true;
                    retorno.roles = validaLogin.roles;
                    retorno.messageErrors = null;
                }              
            }
            catch(Exception e){
                throw e;
            }

            return retorno;
        }

        public List<LoginModel> GetLogin(){
            return new List<LoginModel>();
        }
        public LoginModel getLoginByID(int id){
             return new LoginModel();
        }

        public LoginModel postLogin(LoginModel login){
             return new LoginModel();
        }

        public LoginModel PutLogin(LoginModel login){
             return new LoginModel();
        }

        public LoginModel DeleteLogin(int id){
             return new LoginModel();
        }

    }
}