using System;
using System.Collections.Generic;
using System.Linq;
using webApi.Models;

namespace webApi.Repository {
    public class MyWorkRepository { 
       List<DataCardModel> listaCards = new List<DataCardModel>();

        public MyWorkRepository(){
            for(int i = 1; i <= 1000; i++){
                listaCards.Add(new DataCardModel{
                    id = i,
                    description = string.Format("Trabalho numero {0}" , i),
                    foto = "https://picsum.photos/200/300",
                    href = "#"
                });
            }
        }

        public List<DataCardModel> getPaginationFotos(ParameterPagination parameters){
            return listaCards.Skip(parameters.skip).Take(parameters.take).ToList();
        }

        public DetailProject getDetailProjectByID(int idProjeto)
        {
            List<string> listaFotosProjeto = new List<string>();

            for(int i=0; i <= 18; i++){
                listaFotosProjeto.Add("https://picsum.photos/200/300");
            }
            
            return new DetailProject(){
                ListaGaleria = listaFotosProjeto,
                descriptionWork = new DescriptionBoxModel(){
                    title = "Titulo do projeto",
                    description = "Aqui vai uma breve explicação do projeto , podera ter espaço <br/><br/> ou qualquer outra lorota."
                }
            };
        }
    }

}