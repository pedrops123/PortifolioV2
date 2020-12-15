using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using webApi.Models;
using webApi.Repository;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Authorization;

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
        public List<ButtonsMenuModel> Get() => repository.GetMenu();

        /// <summary>
        /// Cadastra um Menu
        /// </summary>
        [HttpPost]
        public ButtonsMenuModel Post([FromBody] ButtonsMenuModel parameter) => repository.PostMenu(parameter);

        /// <summary>
        /// Atualiza um Menu
        /// </summary>
        [HttpPut]
        public ButtonsMenuModel Put([FromBody] ButtonsMenuModel parameter) => repository.PutMenu(parameter);

        /// <summary>
        /// Deleta um menu
        /// </summary>
        [HttpDelete]
        public bool Delete([FromQuery] int id) => repository.DeleteMenu(id);




    }
}

