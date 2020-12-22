using System;
using System.Collections.Generic;
using Commands;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
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
       IConfiguration configurationGlobal;
        /// <summary>
        /// Construtor da classe 
        /// </summary>
        public WorkController(IConfiguration configuration){
            repository = new MyWorkRepository(configuration);
            this.configurationGlobal = configuration;
        }

        /// <summary>
        /// Retorna lista de projetos
        /// </summary>
        [HttpGet]
        [Authorize(Roles="Adm")]
        public RetornoGlobal<List<CatalogProjeto>> get() =>  repository.Get();

        /// <summary>
        /// Cadastra um projeto
        /// </summary>
        [HttpPost]
        [Authorize(Roles="Adm")]
        public RetornoGlobal<CatalogProjeto> post([FromBody] CreateCatalogProjeto parameter) => repository.Post(parameter);

        /// <summary>
        /// Atualiza um projeto 
        /// </summary>
        [HttpPut]
        [Authorize(Roles="Adm")]
        public RetornoGlobal<CatalogProjeto> put([FromBody] UpdateCatalogProjeto parameter) => repository.Put(parameter);
        
        /// <summary>
        /// Deleta um projeto
        /// </summary>
        [HttpDelete]
        [Authorize(Roles="Adm")]
        public RetornoGlobal<CatalogProjeto> delete([FromQuery] int id) => repository.Delete(id);


        /// <summary>
        /// Coleta projeto por ID
        /// </summary>
        [HttpGet]
        [Route("getById")]
        [Authorize(Roles="Adm")]
        public RetornoGlobal<CatalogProjeto> GetById([FromQuery] int id) =>repository.getByID(id);

        /// <summary>
        /// Faz paginação de projetos
        /// </summary>
        [HttpPost]
        [Route("GetPagination")]
        [AllowAnonymous]
        public RetornoGlobal<List<CatalogProjeto>> getDataPagination([FromBody]ParameterPagination parameter) => repository.getPaginationProjects(parameter);

/*
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
*/
    
    }
    
}