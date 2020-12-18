using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace webApi.Models {
      /// <summary>
      /// Tabela de acessos usuarios 
      /// </summary>
    [Table("UsuarioAcesso")]
    public class UsuarioAcesso {
      /// <summary>
      /// Tabela de acessos usuarios 
      /// </summary>
        [Key]
        public int Id { get; set; }
       /// <summary>
       /// Tipo Acesso 
       /// </summary>
       [MaxLength(5)]
        public string DescricaoAcesso { get; set; }

       /// <summary>
       /// Usuarios
       /// </summary>
       [JsonIgnore]
        public virtual ICollection<UsuariosModel> LoginModel { get; set; }
    }
}
