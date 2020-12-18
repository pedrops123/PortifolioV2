using System;
using System.Collections.Generic;
using System.Linq;
using Commands;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using webApi.Models;
using webApi.Repository;
using webApi.Services;
using webApi.Validators;

namespace webApi.Controllers 
{
    /// <summary>
    /// Controller Login
    /// </summary>
    [ApiController]
    [Route("Login")]
    public class LoginController
    {
        private LoginRepository repositorio;
        IConfiguration configurationGlobal;
        /// <summary>
        /// Construtor da classe
        /// </summary>
        public LoginController(IConfiguration configuration){
            repositorio = new LoginRepository(configuration);
            this.configurationGlobal = configuration;
        }

        /// <summary>
        /// Coleta lista de usuarios
        /// </summary>
        [HttpGet]
        [Authorize(Roles = "Adm")]
        public RetornoGlobal<List<UsuariosModel>> get() => repositorio.GetLogin();

         /// <summary>
        /// Pesquisa usuario por ID
        /// </summary>
        [HttpGet]
        [Authorize(Roles = "Adm")]
        [Route("getById")]
        public RetornoGlobal<UsuariosModel> getById([FromQuery]int id) => repositorio.getLoginByID(id);

        /// <summary>
        /// Cadastra um novo usuario
        /// </summary>
        [HttpPost]
        [Authorize(Roles = "Adm")]
        public RetornoGlobal<UsuariosModel> post([FromBody] CreateLoginCommand login) => repositorio.postLogin(login);

        /// <summary>
        /// Atualiza um usuario
        /// </summary>
        [HttpPut]
        [Authorize(Roles = "Adm")]
        public RetornoGlobal<UsuariosModel> put([FromBody] UpdateLoginCommand login) => repositorio.PutLogin(login);

        /// <summary>
        /// Deleta um usuario
        /// </summary>
        [HttpDelete]
        [Authorize(Roles = "Adm")]
        public RetornoGlobal<UsuariosModel> delete([FromQuery] int id) => repositorio.DeleteLogin(id);


        /// <summary>
        /// Metodo de login  manager portifolio
        /// </summary>
        [HttpPost]
        [Route("Logar")]
        [AllowAnonymous]
        public ValidationLogin ValidaLogin(LoginFormModel dadosUser) => repositorio.ValidationLogin(dadosUser , configurationGlobal);



       

    }
}