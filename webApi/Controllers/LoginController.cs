using System;
using System.Collections.Generic;
using System.Linq;
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
        public List<LoginModel> get() => repositorio.GetLogin();

         /// <summary>
        /// Pesquisa usuario por ID
        /// </summary>
        [HttpGet]
        [Route("getById")]
        public LoginModel getById([FromQuery]int id) => repositorio.getLoginByID(id);

        /// <summary>
        /// Cadastra um novo usuario
        /// </summary>
        [HttpPost]
        public LoginModel post([FromBody] LoginModel login) => repositorio.postLogin(login);

        /// <summary>
        /// Atualiza um usuario
        /// </summary>
        [HttpPut]
        public LoginModel put([FromBody] LoginModel login) => repositorio.PutLogin(login);

        /// <summary>
        /// Deleta um usuario
        /// </summary>
        [HttpDelete]
        public LoginModel delete([FromQuery] int id) => repositorio.DeleteLogin(id);


        /// <summary>
        /// Metodo de login  manager portifolio
        /// </summary>
        [HttpPost]
        [Route("Logar")]
        [AllowAnonymous]
        public ValidationLogin ValidaLogin(LoginModel dadosUser){
           ValidationLogin retornoLogin = new ValidationLogin();
           LoginValidator validator = new LoginValidator();
           ValidationResult result =  validator.Validate(dadosUser); 
           if(result.IsValid){
              retornoLogin =  repositorio.validaLogin(dadosUser);
              if(retornoLogin.validado){
                  dadosUser.roles = retornoLogin.roles;
                  TokenService tokenServiceClass = new TokenService(configurationGlobal);
                  retornoLogin.token =  tokenServiceClass.GenerateToken(dadosUser);
              }
           }
           else 
           {  
               result.Errors.ToList().ForEach(
                   f => retornoLogin.messageErrors.Add(f.ErrorMessage) 
               );
           }
            return retornoLogin;
        }



       

    }
}