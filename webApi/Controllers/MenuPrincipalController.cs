using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using webApi.Models;
using webApi.Repository;

namespace webApi.Controllers {

    [ApiController]
    [Route("Menu")]
    public class MenuPrincipalController
    {
        MenuPrincipalRepository repository;
        public MenuPrincipalController()
        {
            repository = new MenuPrincipalRepository();
        }
        
        [HttpGet]
        [Route("RetornaMenu")]
        public List<ButtonsMenuModel> retornaValorTeste(){
            return repository.retornaDadosMenu();
        }

    }
}

