using System;
using System.Collections.Generic;

namespace webApi.Models {
    /// <summary>
    /// Model Validação login
    /// </summary>
    public class ValidationLogin {

        /// <summary>
        /// Construtor validacao login
        /// </summary>
        public ValidationLogin(){
            messageErrors = new List<string>();
        }

        /// <summary>
        /// Validado retorno login
        /// </summary>
        public bool validado { get; set; }
        /// <summary>
        /// Lista de erros retorno validação
        /// </summary>
        public List<string> messageErrors { get; set;}
        /// <summary>
        /// roles de acesso 
        /// </summary>
        public UsuarioAcesso roles { get; set; }
        /// <summary>
        /// Token retorno login
        /// </summary>
        public string token { get; set; }
    }

}