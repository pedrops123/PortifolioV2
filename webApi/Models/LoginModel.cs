using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webApi.Models {
    /// <summary>
    /// Model Login
    /// </summary>
    [Table("Usuarios")]
    public class LoginModel {

        /// <summary>
        /// Propriedade id login usuario
        /// </summary>
        [Key]
        public int id { get; set; }    

        /// <summary>
        /// Propriedade string login usuario
        /// </summary>
        [MaxLength(20)]
        public string login { get; set; }

        /// <summary>
        /// Propriedade string senha usuario
        /// </summary>
        [MaxLength(100)]
        public string senha { get; set; }

        /// <summary>
        /// Acessos usuario
        /// </summary>
        [MaxLength(10)]
        public string roles { get; set; }
    }

}