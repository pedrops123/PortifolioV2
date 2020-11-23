using System;

namespace webApi.Models {
    /// <summary>
    /// Model Login
    /// </summary>
    public class LoginModel{

        /// <summary>
        /// Propriedade string login usuario
        /// </summary>
        public string login { get; set; }

        /// <summary>
        /// Propriedade string senha usuario
        /// </summary>
        public string senha { get; set; }


        public string roles { get; set; }
    }

}