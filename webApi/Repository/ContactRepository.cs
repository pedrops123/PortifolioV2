
using System;
using System.Net;
using System.Net.Mail;
using Microsoft.Extensions.Configuration;
using webApi.Models;

namespace webApi.Repository {

    public class ContactRepository {
        string email;
        string senha;
        IConfiguration _conf;
        public ContactRepository(IConfiguration configuration){
            this._conf = configuration;
            this.email = _conf.GetSection("email").Value;
            this.senha = _conf.GetSection("senha").Value;
        }
        public ValidationContactModel sendEmail(ParameterSendEmail parametro){
            // Comeco enviar email
            ValidationContactModel retorno = new ValidationContactModel();
            try
            {
                var smtpClient = new SmtpClient("smtp.gmail.com"){
                    Port = 587,
                    Credentials = new NetworkCredential(email,senha),
                    EnableSsl = true
                };

                string mensagemEmail = $"Nova mensagem recebida ! \n \n Responder á : { parametro.email } \n \n Mensagem: { parametro.CorpoMensagem }";

                smtpClient.Send(
                    new MailMessage(parametro.email ,
                     "pedro.furlan1304@hotmail.com" ,
                      "Mensagem Portifolio" ,
                       mensagemEmail
                       ));

                retorno.enviado = true;
                retorno.messageErrors = null;
            }
            catch(Exception e){
                retorno.enviado = false;
                retorno.messageErrors.Add($"Exception \n\n ${ e.ToString() }");
            }
            return retorno;
        }


    }

}