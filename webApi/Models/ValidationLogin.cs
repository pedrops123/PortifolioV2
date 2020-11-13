using System;
using System.Collections.Generic;

namespace webApi.Models {

    public class ValidationLogin {

        public ValidationLogin(){
            messageErrors = new List<string>();
        }
        public bool validado { get; set; }
        public List<string> messageErrors { get; set;}
        public string token { get; set; }
    }

}