using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using webApi.Models;

namespace Commands {

    /// <summary>
    /// Classe de criação Projeto
    /// </summary>
    public class CreateCatalogProjeto {
        /// <summary>
        /// Nome do projeto
        /// </summary>
        public string nome_projeto { get; set; }
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
       
        public virtual List<FotosProjeto> ListaFotos { get; set; } 

    }
}