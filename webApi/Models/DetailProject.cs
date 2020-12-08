using System;
using System.Collections.Generic;

namespace webApi.Models {

      /// <summary>
      /// Detalhamento Projeto model 
      /// </summary>
    public class DetailProject {
        public List<string> ListaGaleria { get; set; }
        public DescriptionBoxModel descriptionWork { get; set; }

    }
}