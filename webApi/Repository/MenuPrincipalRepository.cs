using System;
using System.Collections.Generic;
using System.Linq;
using Commands;
using Contexto;
using Microsoft.Extensions.Configuration;
using webApi.Models;
using webApi.Validators;

namespace webApi.Repository {
    public class MenuPrincipalRepository {

       private ContextoDB contexto;
      
        public MenuPrincipalRepository(IConfiguration configuration){

            this.contexto = new ContextoDB(configuration);
            /*
            this.listaRetorno = new List<ButtonsMenuModel>(){
                new ButtonsMenuModel(){
                    Id = 1,
                    description = "Inicio",
                    href = "inicio",
                    color = null
                },
                 new ButtonsMenuModel(){
                    Id = 2,
                    description = "Meus Trabalhos",
                    href = "work",
                    color = null
                },
                 new ButtonsMenuModel(){
                    Id = 3,
                    description = "Contato",
                    href = "contact",
                    color = null
                }
            };
            */
        }

        public RetornoGlobal<List<ButtonsMenuModel>> GetMenu(){
            RetornoGlobal<List<ButtonsMenuModel>> retorno = new RetornoGlobal<List<ButtonsMenuModel>>();
            try
            {
                retorno.status = true;
                retorno.RetornoObjeto = contexto.TabelaButtonsMenu.ToList();;
            }
            catch(Exception e){
                retorno.status = false;
                retorno.errors.Append(e.Message);
                retorno.errors.Append(e.InnerException.ToString());
            }
            return retorno;
        }
        public RetornoGlobal<ButtonsMenuModel> PostMenu(CreateMenuCommand parameter){
            RetornoGlobal<ButtonsMenuModel> retorno = new RetornoGlobal<ButtonsMenuModel>();
            try
            {
                CreateMenuValidator validacao = new CreateMenuValidator(contexto);
                var result = validacao.Validate(parameter);
                if(result.IsValid){
                    ButtonsMenuModel registro = new ButtonsMenuModel(){
                        description = parameter.description,
                        href = parameter.href
                    };

                    contexto.TabelaButtonsMenu.Add(registro);
                    contexto.SaveChanges();
        
                    retorno.status = true;
                    retorno.RetornoObjeto = registro;
                }
                else
                {
                    retorno.status = false;
                    result.Errors.ToList().ForEach(r =>
                        retorno.errors.Add(r.ToString())
                     );
                }
            }
            catch(Exception e){
                retorno.status = false;
                retorno.errors.Append(e.Message);
                retorno.errors.Append(e.InnerException.ToString());
            }
            return retorno;
        }

        public RetornoGlobal<ButtonsMenuModel> PutMenu(UpdateMenuCommand parameter){
            RetornoGlobal<ButtonsMenuModel> retorno = new RetornoGlobal<ButtonsMenuModel>();
            try
            {
                UpdateMenuValidator validacao = new UpdateMenuValidator(contexto);
                var result = validacao.Validate(parameter);
                if(result.IsValid){
                    var registro = this.contexto.TabelaButtonsMenu.Where(r => r.Id == parameter.Id).First();
                    registro.description = parameter.description;
                    registro.href = parameter.href;
                    contexto.SaveChanges();

                    retorno.status = true;
                    retorno.RetornoObjeto = registro;   
                }
                else
                {
                    retorno.status = false;
                    result.Errors.ToList().ForEach(r =>
                        retorno.errors.Add(r.ToString())
                     );
                }
            }
            catch(Exception e){
              retorno.status = false;
              retorno.errors.Append(e.Message);
              retorno.errors.Append(e.InnerException.ToString());
            }
            return retorno;
        }

        public RetornoGlobal<ButtonsMenuModel> DeleteMenu(int id){
            RetornoGlobal<ButtonsMenuModel> retorno = new RetornoGlobal<ButtonsMenuModel>();
            try
            {
                if(id != null || id != 0)
                {
                    var itemLista = this.contexto.TabelaButtonsMenu.Where(r => r.Id == id).FirstOrDefault();
                    if(itemLista != null){
                        contexto.TabelaButtonsMenu.Remove(itemLista);    
                        contexto.SaveChanges();
                        retorno.status = true;
                        retorno.RetornoObjeto = itemLista;
                    }

                }
                else
                {
                    retorno.status = false;
                    retorno.errors.Add("Id não pode ser 0 ou null.");
                }

            }
            catch(Exception e){
              retorno.status = false;
              retorno.errors.Append(e.Message);
              retorno.errors.Append(e.InnerException.ToString());
            }
            return retorno;
        }

        public RetornoGlobal<ButtonsMenuModel> getByID(int id){
            RetornoGlobal<ButtonsMenuModel> retorno = new RetornoGlobal<ButtonsMenuModel>();
            try
            {
                if( id != 0 || id != null ){
                    retorno.RetornoObjeto = contexto.TabelaButtonsMenu.Where(r=>r.Id == id).FirstOrDefault();
                    retorno.status = true;
                }
                else
                {
                    retorno.RetornoObjeto = null;
                    retorno.status = false;
                    retorno.errors.Add("Id não pode ser 0 ou null.");
                }
            }
            catch(Exception e){
                retorno.status = false;
                retorno.errors.Append(e.Message);
                retorno.errors.Append(e.InnerException.ToString());
            }

            return retorno;
        }


    }
}