using System;
using System.Collections.Generic;
using webApi.Models;

namespace webApi.Repository {
    public class MenuPrincipalRepository {
        public List<ButtonsMenuModel> retornaDadosMenu(){

          List<ButtonsMenuModel> listaRetorno = new List<ButtonsMenuModel>(){
                new ButtonsMenuModel(){
                    description = "Inicio",
                    href = "inicio",
                    color = null
                },
                 new ButtonsMenuModel(){
                    description = "Meus Trabalhos",
                    href = "work",
                    color = null
                },
                 new ButtonsMenuModel(){
                    description = "Contato",
                    href = "contact",
                    color = null
                }
            };
            return listaRetorno;
        }





    }
}