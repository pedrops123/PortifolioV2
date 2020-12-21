using System;
using System.ComponentModel.DataAnnotations;

namespace Commands{
    /// <summary>
    /// Classe de Atualização Botão menu
    /// </summary>
    public class UpdateMenuCommand {

        /// <summary>
        /// Primary key botao
        /// </summary>
        public int Id { get; set; }

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