using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace webApi.Models {

    [Table("FotosProjeto")]
    public class FotosProjeto {

        [Key]
        public int Id { get; set; }
        public int IdProjeto { get; set; }
        public string caminhoArquivo { get; set; }

        [JsonIgnore]
        public virtual CatalogProjeto projetoVinculado { get; set; }
    }
}
