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
       private MyWorkRepository repository;
        /// <summary>
        /// Construtor da classe 
        /// </summary>
        public WorkController(){
            repository = new MyWorkRepository();
        }

        /// <summary>
        /// Retorna Paginação dos trabalhos gerais cadastrados no sistema
        /// </summary>
        [HttpPost]
        [Route("GetPagination")]
        [AllowAnonymous]
        public List<DataCardModel> getDataPagination(ParameterPagination parametro){
            
            return repository.getPaginationFotos(parametro);
        }

        /// <summary>
        /// Retorna o detalhamento do projeto pelo id 
        /// </summary>
        [HttpGet]
        [Route("GetDetailProject/{idProjeto}")]
        [AllowAnonymous]
        public DetailProject getDetailProject([FromRoute] int idProjeto){
            return repository.getDetailProjectByID(idProjeto);
        }

    
    }
    
}