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

        public List<ButtonsMenuModel> GetMenu(){
            return contexto.TabelaButtonsMenu.ToList();
        }
        public ButtonsMenuModel PostMenu(ButtonsMenuModel parameter){
            try
            {
                var registro = contexto.TabelaButtonsMenu.Add(parameter);
                contexto.SaveChanges();
            }
            catch(Exception e){
                throw e;
            }
            return parameter;
        }

        public ButtonsMenuModel PutMenu(ButtonsMenuModel parameter){
            try
            {
                var registro = this.contexto.TabelaButtonsMenu.Where(r=>r.Id == parameter.Id).First();
                registro.description = parameter.description;
                registro.href = parameter.href;
                contexto.SaveChanges();
            }
            catch(Exception e){
                throw e;
            }
            return parameter;
        }


        public bool DeleteMenu(int id){
            bool retorno = false;
            try
            {
                var itemLista = this.contexto.TabelaButtonsMenu.Where(r => r.Id == id).First();
                contexto.TabelaButtonsMenu.Remove(itemLista);    
                contexto.SaveChanges();
                retorno = true;
            }
            catch(Exception e){
                throw e;
            }
            return retorno;
        }


    }
}