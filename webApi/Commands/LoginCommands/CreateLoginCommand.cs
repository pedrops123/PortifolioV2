using System;
using System.ComponentModel.DataAnnotations;

namespace Commands{
    /// <summary>
    /// Classe de criação Usuario
    /// </summary>
    public class CreateLoginCommand {
        
        /// <summary>
        /// Nome de usuario
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




    }

}