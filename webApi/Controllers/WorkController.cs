using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using webApi.Models;
using webApi.Repository;

namespace webApi.Controllers 
{

     /// <summary>
     /// Controller Meus Trabalhos
     /// </summary>
    [ApiController]
    [Route("work")]
    public class WorkController {
        MyWorkRepository repository;
        public WorkController(){
            repository = new MyWorkRepository();
        }

        /// <summary>
        /// Retorna Paginação de trabalhos cadastrados no sistema
        /// </summary>
        [HttpPost]
        [Route("GetPagination")]
        [AllowAnonymous]
        public List<DataCardModel> getDataPagination(ParameterPagination parametro){
            return repository.getPaginationFotos(parametro);
        }

    
    }
    
}