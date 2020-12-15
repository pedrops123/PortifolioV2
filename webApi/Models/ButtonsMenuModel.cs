using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webApi.Models {
    /// <summary>
    /// Model Botões menu principal
    /// </summary>
    [Table("ButtonsMenu")]
    public class ButtonsMenuModel {
         /// <summary>
        /// Primary key botao
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Descrição botão
        /// </summary>
        [MaxLength(100)]
         public string description { get; set; } 
        /// <summary>
        /// Cor botão
        /// </summary>
        [MaxLength(10)]
         public string color { get; set; }
        /// <summary>
        /// Link botão
        /// </summary>
        [MaxLength(100)]
         public string href { get; set; }
    }
}
