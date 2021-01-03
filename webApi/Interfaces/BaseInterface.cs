using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using webApi.Models;

namespace webApi.Interfaces{

    /// <summary>
    /// Classe de interface base de rotas
    /// </summary>
    public interface BaseInterface<T,C,U>{

        /// <summary>
        /// Coleta lista de registros 
        /// </summary>
        [HttpGet]
        RetornoGlobal<List<T>> Get();

        /// <summary>
        /// Coleta registro por ID
        /// </summary>
        [HttpGet]
        [Route("GetById")]
        RetornoGlobal<T> GetByID([FromQuery] int id);

        /// <summary>
        /// Cadastra Registro 
        /// </summary>
        [HttpPost]
        RetornoGlobal<T> Post([FromBody] C CreateParameter);

        /// <summary>
        /// Atualiza Registro
        /// </summary>
        [HttpPut]
        RetornoGlobal<T> Put([FromBody] U UpdateParameter);

        /// <summary>
        /// Deleta Registro
        /// </summary>
        [HttpDelete]
        RetornoGlobal<T> Delete([FromQuery] int id);
    
    }

}