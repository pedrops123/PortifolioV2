using System;
using System.Collections.Generic;

namespace  webApi.Models{
    public class RetornoGlobal<T> {

        public RetornoGlobal(){
            this.errors = new List<string>();
        }

            public bool status { get; set; }
            public T RetornoObjeto { get; set; }

            public List<string> errors { get; set;}
    }

}