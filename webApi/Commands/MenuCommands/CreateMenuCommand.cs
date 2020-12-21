using System;
using System.ComponentModel.DataAnnotations;

namespace Commands{
    /// <summary>
    /// Classe de criação Botão menu
    /// </summary>
    public class CreateMenuCommand {

        /// <summary>
        /// Descrição botão
        /// </summary>
        [MaxLength(100)]
         public string description { get; set; } 

        /// <summary>
        /// Link botão
        /// </summary>
        [MaxLength(100)]
        public string href { get; set; }
    }
}