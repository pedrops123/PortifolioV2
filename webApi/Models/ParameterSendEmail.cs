using System;

namespace webApi.Models{
    /// <summary>
    /// Parametro  envio de mesnsagem
    /// </summary>
    public class ParameterSendEmail{

        /// <summary>
        /// Propriedade email usuario contato
        /// </summary>
        public string email { get; set; }

        /// <summary>
        /// Propriedade corpo da mensagem 
        /// </summary>
        public string CorpoMensagem { get; set; }
    }    
}
