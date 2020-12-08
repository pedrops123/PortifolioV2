using System;

namespace webApi.Models {
    /// <summary>
    /// Modelo parametro paginação
    /// </summary>
    public class ParameterPagination
    {
        /// <summary>
        /// Pula uma certa quantidade de dados
        /// </summary>
        public int skip { get; set; }

        /// <summary>
        /// Coleta uma certa quantidade de dados
        /// </summary>
        public int take { get; set; }
    }

}
