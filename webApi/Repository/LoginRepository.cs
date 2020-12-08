using System;
using System.Collections.Generic;
using System.Linq;
using webApi.Models;

namespace webApi.Repository{
    public class LoginRepository {

        List<LoginModel> BDusers = new List<LoginModel>(){
            new LoginModel(){
                login  = "pedro.furlan",
                senha =  "123456",
                roles = "Adm"
            }
        };        

        public ValidationLogin validaLogin(LoginModel dadosUser){
            ValidationLogin retorno = new ValidationLogin();
            try
            {
                var validaLogin = BDusers.Where(r => r.login == dadosUser.login && r.senha == dadosUser.senha ).FirstOrDefault();
                if(validaLogin == null){
                    retorno.validado = false;
                    retorno.messageErrors.Add(new string("Usuario ou senha incorretas !"));
                }else
                {
                    retorno.validado = true;
                    retorno.roles = validaLogin.roles;
                    retorno.messageErrors = null;
                }              
            }
            catch(Exception e){
                throw e;
            }

            return retorno;
        }

    }
}