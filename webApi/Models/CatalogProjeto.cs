using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace webApi.Models {

    [Table("CatalogProjeto")]
    public class CatalogProjeto {

        [Key]
        public int Id { get; set; }

        public string nome_projeto { get; set; }

        public string img_thumbnail { get; set; }

        public string descritivo_capa { get; set; }

        public string texto_projeto { get; set; }

        
        public virtual List<FotosProjeto> ListaFotos { get; set; } 
    }
}