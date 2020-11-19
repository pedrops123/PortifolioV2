using System;
using System.Linq;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using webApi.Models;
using webApi.Repository;
using webApi.Validators;

namespace webApi.Controllers 
{
    [ApiController]
    [Route("Login")]
    public class LoginController
    {
        LoginRepository repositorio;
        
        public LoginController(){
            repositorio = new LoginRepository();
        }

        [HttpPost]
        [Route("Logar")]
        /// <summary>
        /// Metodo logar 
        /// </summary>
        public ValidationLogin ValidaLogin(LoginModel dadosUser){
           ValidationLogin retornoLogin = new ValidationLogin();
           LoginValidator validator = new LoginValidator();
           ValidationResult result =  validator.Validate(dadosUser); 
           if(result.IsValid){
              retornoLogin =  repositorio.validaLogin(dadosUser);
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