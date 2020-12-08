using System;
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
            repositorio = new LoginRepository();
            this.configurationGlobal = configuration;
        }

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