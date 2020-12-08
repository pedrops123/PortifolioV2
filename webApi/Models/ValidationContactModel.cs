using System;
using System.Collections.Generic;

namespace webApi.Models {
     /// <summary>
     /// Model validacao mensagem email
     /// </summary>
    public class ValidationContactModel {

        public ValidationContactModel(){
            messageErrors = new List<string>();
        }

        /// <summary>
        /// Parametro que define se foi enviado ou não
        /// </summary>
        public bool enviado { get; set; }

        /// <summary>
        /// Lista de motivos na qual nao foi enviado
        /// </summary>
        public List<string> messageErrors { get; set; }
    }

}