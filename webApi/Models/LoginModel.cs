using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace webApi.Models {
    /// <summary>
    /// Model Login
    /// </summary>
    [Table("UsuariosModel")]
    public class UsuariosModel {

        /// <summary>
        /// Propriedade id login usuario
        /// </summary>
        [Key]
        public int Id { get; set; }    

        /// <summary>
        /// Propriedade string login usuario
        /// </summary>
        [MaxLength(20)]
        public string Login { get; set; }

        /// <summary>
        /// Propriedade string senha usuario
        /// </summary>
        [MaxLength(100)]
        public string Senha { get; set; }

        /// <summary>
        /// Acesso usuario fk
        /// </summary>
        public int UsuarioAcessoId { get; set; }

        /// <summary>
        /// Acesso usuario
        /// </summary>
       [JsonIgnore]
        public virtual UsuarioAcesso UsuarioAcesso { get; set; }
    }

}