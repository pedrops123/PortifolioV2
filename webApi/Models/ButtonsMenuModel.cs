using System;

namespace webApi.Models {
    /// <summary>
    /// Model Botões menu principal
    /// </summary>
    public class ButtonsMenuModel {
         /// <summary>
        /// Primary key botao
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Descrição botão
        /// </summary>
         public string description { get; set; } 
        /// <summary>
        /// Cor botão
        /// </summary>
         public string color { get; set; }
        /// <summary>
        /// Link botão
        /// </summary>
         public string href { get; set; }
    }
}
