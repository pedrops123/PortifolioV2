using System;

namespace webApi.Models {
    /// <summary>
    /// Model Botões menu principal
    /// </summary>
    public class ButtonsMenuModel {
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
