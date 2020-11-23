using System;

namespace webApi.Models {
    /// <summary>
    /// Dados Card generico
    /// </summary>
    public class  DataCardModel {
        /// <summary>
        /// id Card 
        /// </summary>
        public int id {get; set; }
        /// <summary>
        /// foto card
        /// </summary>
        public string foto { get; set; }
        /// <summary>
        /// descrição card
        /// </summary>
        public string description { get; set; }
        /// <summary>
        /// Link card
        /// </summary>
        public string href { get; set; }

    }

}
