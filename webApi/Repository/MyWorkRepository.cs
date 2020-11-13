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




    }

}