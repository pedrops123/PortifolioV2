using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using webApi.Models;
using webApi.Repository;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Authorization;
using Commands;
using webApi.Interfaces;

namespace webApi.Controllers {

   /// <summary>
   /// Controller menu Principal
   /// </summary>/
    [ApiController]
    [Route("Menu")]
    public class MenuPrincipalController : BaseInterface<ButtonsMenuModel,CreateMenuCommand,UpdateMenuCommand>
    {
      private MenuPrincipalRepository repository;
        /// <summary>
        /// Construtor da classe
        /// </summary>

        public MenuPrincipalController(IConfiguration configuration)
        {
            repository = new MenuPrincipalRepository(configuration);
        }

        /// <summary>
        /// Retorna Dados Menu
        /// </summary>
        [HttpGet]
        [AllowAnonymous]
        public RetornoGlobal<List<ButtonsMenuModel>> Get() => repository.GetMenu();
        
        /// <summary>
        /// Coleta um menu por ID
        /// </summary>
        [HttpGet]
        [Authorize(Roles = "Adm")]
        [Route("GetById")] 
        public RetornoGlobal<ButtonsMenuModel> GetByID([FromQuery] int id) => repository.getByID(id);
  

        /// <summary>
        /// Cadastra um Menu
        /// </summary>
        [HttpPost]
        [Authorize(Roles = "Adm")]
        public RetornoGlobal<ButtonsMenuModel> Post([FromBody] CreateMenuCommand CreateParameter) => repository.PostMenu(CreateParameter);
        

        /// <summary>
        /// Atualiza um Menu
        /// </summary>
        [HttpPut]
        [Authorize(Roles = "Adm")]
        public RetornoGlobal<ButtonsMenuModel> Put([FromBody] UpdateMenuCommand UpdateParameter) => repository.PutMenu(UpdateParameter);
              
        /// <summary>
        /// Deleta um menu
        /// </summary>
        [HttpDelete]
        [Authorize(Roles = "Adm")]
        public RetornoGlobal<ButtonsMenuModel> Delete([FromQuery] int id) => repository.DeleteMenu(id);


    }
}

