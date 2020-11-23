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
        MenuPrincipalRepository repository;
        public MenuPrincipalController()
        {
            repository = new MenuPrincipalRepository();
        }
        
        /// <summary>
        /// Retorna menu principal do sistema
        /// </summary>
        [HttpGet]
        [Route("RetornaMenu")]
        [AllowAnonymous]
        public List<ButtonsMenuModel> retornaValorTeste(){
            return repository.retornaDadosMenu();
        }

    }
}

