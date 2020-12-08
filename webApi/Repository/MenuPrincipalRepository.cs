using System;
using System.Collections.Generic;
using System.Linq;
using webApi.Models;

namespace webApi.Repository {
    public class MenuPrincipalRepository {
       private List<ButtonsMenuModel> listaRetorno = new List<ButtonsMenuModel>(){
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
        public MenuPrincipalRepository(){
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
            return this.listaRetorno;
        }
        public ButtonsMenuModel PostMenu(ButtonsMenuModel parameter){
            try
            {
                var ultimoRegistroID = this.listaRetorno.LastOrDefault().Id;
                parameter.Id =  ultimoRegistroID + 1;
                this.listaRetorno.Add(parameter);
            }
            catch(Exception e){
                throw e;
            }
            return parameter;
        }

        public ButtonsMenuModel PutMenu(ButtonsMenuModel parameter){
            try
            {
                var registro = this.listaRetorno.Where(r=>r.Id == parameter.Id).FirstOrDefault();
                registro = parameter;
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
                var itemLista = this.listaRetorno.Where(r => r.Id == id).FirstOrDefault();
                this.listaRetorno.Remove(itemLista);    
                retorno = true;
            }
            catch(Exception e){
                throw e;
            }
            return retorno;
        }


    }
}