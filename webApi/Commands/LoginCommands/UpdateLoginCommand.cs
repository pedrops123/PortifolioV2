using System;
using System.ComponentModel.DataAnnotations;

namespace Commands {
    public class UpdateLoginCommand {
        
        /// <summary>
        /// id usuario 
        /// </summary>
        public int Id { get; set; }

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