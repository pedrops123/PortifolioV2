using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using webApi.Models;
using webApi.Repository;

namespace webApi.Controllers 
{
    [ApiController]
    [Route("work")]
    public class WorkController {
        MyWorkRepository repository;
        public WorkController(){
            repository = new MyWorkRepository();
        }


        [HttpPost]
        [Route("GetPagination")]
        public List<DataCardModel> getDataPagination(ParameterPagination parametro){
            return repository.getPaginationFotos(parametro);
        }

    
    }
    
}