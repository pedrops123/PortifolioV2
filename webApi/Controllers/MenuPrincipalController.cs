using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using webApi.Models;
using webApi.Repository;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Authorization;
using Commands;

namespace webApi.Controllers {

   /// <summary>
   /// Controller menu Principal
   /// </summary>/
    [ApiController]
    [Route("Menu")]
    public class MenuPrincipalController
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
        /// Cadastra um Menu
        /// </summary>
        [HttpPost]
        [Authorize(Roles = "Adm")]
        public RetornoGlobal<ButtonsMenuModel> Post([FromBody] CreateMenuCommand parameter) => repository.PostMenu(parameter);

        /// <summary>
        /// Atualiza um Menu
        /// </summary>
        [HttpPut]
        [Authorize(Roles = "Adm")]
        public RetornoGlobal<ButtonsMenuModel> Put([FromBody] UpdateMenuCommand parameter) => repository.PutMenu(parameter);

        /// <summary>
        /// Deleta um menu
        /// </summary>
        [HttpDelete]
        [Authorize(Roles = "Adm")]
        public RetornoGlobal<ButtonsMenuModel> Delete([FromQuery] int id) => repository.DeleteMenu(id);

        /// <summary>
        /// Coleta um menu por ID
        /// </summary>
        [HttpGet]
        [Authorize(Roles = "Adm")]
        [Route("getById")] 
        public RetornoGlobal<ButtonsMenuModel> getById([FromQuery] int id) => repository.getByID(id);



    }
}

