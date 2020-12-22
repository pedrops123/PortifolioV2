using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using webApi.Models;

namespace Commands {

    /// <summary>
    /// Classe de atualização Projeto
    /// </summary>
    public class UpdateCatalogProjeto {
        /// <summary>
        /// Id do registro
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Imagem de inicio 
        /// </summary>
        public string img_thumbnail { get; set; }
        /// <summary>
        /// Descricao card
        /// </summary>
        public string descritivo_capa { get; set; }
        /// <summary>
        /// Texto do projeto
        /// </summary>
        public string texto_projeto { get; set; }
         /// <summary>
        /// Fotos do projeto 
        /// </summary>
        [JsonIgnore]
        public virtual List<FotosProjeto> ListaFotos { get; set; } 
    }
}