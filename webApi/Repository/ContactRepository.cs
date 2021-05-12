
using System;
using System.Net;
using System.Net.Mail;
using webApi.Models;

namespace webApi.Repository {

    public class ContactRepository {

        public ContactRepository(){
            
        }
        public ValidationContactModel sendEmail(){
            // Comeco enviar email
        ValidationContactModel retorno = new ValidationContactModel();
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("pedro.furlan1304@hotmail.com");
                mail.To.Add("pedro.furlan1304@hotmail.com");

                mail.Subject = "Teste email";
                mail.Body = "E-mail enviado com sucesso !";
                

                SmtpClient smtp = new SmtpClient("smtp-mail.outlook.com");

                
                smtp.Send(mail);

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