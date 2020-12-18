using System;
using System.Collections.Generic;
using System.Linq;
using Contexto;
using Microsoft.Extensions.Configuration;
using webApi.Models;

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
        public RetornoGlobal<ButtonsMenuModel> PostMenu(ButtonsMenuModel parameter){
            RetornoGlobal<ButtonsMenuModel> retorno = new RetornoGlobal<ButtonsMenuModel>();
            try
            {
                var registro = contexto.TabelaButtonsMenu.Add(parameter);
                contexto.SaveChanges();

                retorno.status = true;
                retorno.RetornoObjeto = parameter;
            }
            catch(Exception e){
                retorno.status = false;
                retorno.errors.Append(e.Message);
                retorno.errors.Append(e.InnerException.ToString());
            }
            return retorno;
        }

        public RetornoGlobal<ButtonsMenuModel> PutMenu(ButtonsMenuModel parameter){
            RetornoGlobal<ButtonsMenuModel> retorno = new RetornoGlobal<ButtonsMenuModel>();
            try
            {
                var registro = this.contexto.TabelaButtonsMenu.Where(r=>r.Id == parameter.Id).First();
                registro.description = parameter.description;
                registro.href = parameter.href;
                contexto.SaveChanges();

                retorno.status = true;
                retorno.RetornoObjeto = parameter;
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
                var itemLista = this.contexto.TabelaButtonsMenu.Where(r => r.Id == id).First();
                contexto.TabelaButtonsMenu.Remove(itemLista);    
                contexto.SaveChanges();
                retorno.status = true;
                retorno.RetornoObjeto = itemLista;
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