using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using webApi.Models;
using webApi.Repository;

namespace webApi.Controllers 
{
    /// <summary>
    /// Controller Meu Contato
    /// </summary>
    [ApiController]
    [Route("Contact")]
    public class ContactController {

        private ContactRepository repository;
        /// <summary>
        /// Construtor da classe Meu Contato
        /// </summary>
        public ContactController(){
            repository = new ContactRepository();
        }

        /// <summary>
        /// Metodo de enviar e-mail
        /// </summary>
        
        [HttpPost]
        [AllowAnonymous]
        [Route("sendMail")]
        public ValidationContactModel SendEmail(){
            return repository.sendEmail();
        }


    }
}