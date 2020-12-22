using System;
using System.Collections.Generic;
using System.Linq;
using Commands;
using Contexto;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using webApi.Models;
using webApi.Validators;

namespace webApi.Repository {
    public class MyWorkRepository { 
      // List<DataCardModel> listaCards = new List<DataCardModel>();
         private ContextoDB contexto;
        public MyWorkRepository(IConfiguration configuration){
            this.contexto = new ContextoDB(configuration);
            /*
            for(int i = 1; i <= 1000; i++){
                listaCards.Add(new DataCardModel{
                    id = i,
                    description = string.Format("Trabalho numero {0}" , i),
                    foto = "https://picsum.photos/200/300",
                    href = "#"
                });
            }
            */
        }


        public RetornoGlobal<List<CatalogProjeto>> Get(){
            RetornoGlobal<List<CatalogProjeto>> retorno = new RetornoGlobal<List<CatalogProjeto>>();
            try
            {
                retorno.RetornoObjeto = contexto.TabelaCatalogProjeto.Include(r => r.ListaFotos).ToList();
                retorno.status =  true; 
            }
            catch(Exception e)
            {
              retorno.status = false;
              retorno.errors.Append(e.Message);
              retorno.errors.Append(e.InnerException.ToString());
            }
            return retorno;
        }

        public RetornoGlobal<CatalogProjeto> Post (CreateCatalogProjeto parameter){
            RetornoGlobal<CatalogProjeto> retorno = new RetornoGlobal<CatalogProjeto>();
            try
            {
                CreateCatalogValidator validator = new CreateCatalogValidator(contexto);
                var result = validator.Validate(parameter);

                if(result.IsValid) {

                    CatalogProjeto objetoMontado = new CatalogProjeto();
                    objetoMontado.nome_projeto = parameter.nome_projeto;
                    objetoMontado.img_thumbnail = parameter.img_thumbnail;
                    objetoMontado.descritivo_capa = parameter.descritivo_capa;
                    objetoMontado.texto_projeto = parameter.texto_projeto;
                    objetoMontado.ListaFotos = parameter.ListaFotos;

                    contexto.TabelaCatalogProjeto.Add(objetoMontado);
                    contexto.SaveChanges();
                    retorno.status = true;
                    retorno.RetornoObjeto = objetoMontado;
                }
                else {
                    retorno.status = false;
                    result.Errors.ToList().ForEach(r =>
                        retorno.errors.Add(r.ToString())
                     );
                }
            }
            catch(Exception e) {
                retorno.status = false;
                retorno.errors.Append(e.Message);
                retorno.errors.Append(e.InnerException.ToString());
            }

            return retorno;
        }
 
        public RetornoGlobal<CatalogProjeto> Put(UpdateCatalogProjeto parameter){
            RetornoGlobal<CatalogProjeto> retorno = new RetornoGlobal<CatalogProjeto>();
            try
            {
                UpdateCatalogValidator validator = new UpdateCatalogValidator(contexto);
                var result =  validator.Validate(parameter);
                if(result.IsValid){
                    var registro = contexto.TabelaCatalogProjeto.Where(r=>r.Id ==parameter.Id).First();
                    registro.img_thumbnail = parameter.img_thumbnail;
                    registro.descritivo_capa = parameter.descritivo_capa;
                    registro.texto_projeto = parameter.texto_projeto;
                    contexto.SaveChanges();
                    retorno.status = true;
                    retorno.RetornoObjeto = registro;
                }
                else
                {
                    retorno.status = false;
                    result.Errors.ToList().ForEach(r =>
                        retorno.errors.Add(r.ToString())
                     );                        
                }
            }
            catch(Exception e){
                retorno.status = false;
                retorno.errors.Append(e.Message);
                retorno.errors.Append(e.InnerException.ToString());
            }

            return retorno;
        }

        public RetornoGlobal<CatalogProjeto> Delete(int id){
            RetornoGlobal<CatalogProjeto> retorno = new RetornoGlobal<CatalogProjeto>();
            try
            {
                if(id != null){
                    var verificaExistente = contexto.TabelaCatalogProjeto.Where(r=>r.Id == id).FirstOrDefault();
                    if(verificaExistente == null){
                        retorno.status = false;
                        retorno.errors.Add("Registro não existente.");
                    }
                    else
                    {
                        // Remove todas as fotos alocadas para o projeto
                        var listaFotos = contexto.TabelaFotosProjeto.Where(r=>r.IdProjeto == verificaExistente.Id).ToList();
                        if(listaFotos.Count > 0){
                            contexto.TabelaFotosProjeto.RemoveRange(listaFotos);
                            contexto.SaveChanges();
                        }

                        //Remove projeto
                        contexto.TabelaCatalogProjeto.Remove(verificaExistente);
                        contexto.SaveChanges();
                        retorno.status = true;
                        retorno.RetornoObjeto = verificaExistente;
                    }
                }else
                {
                    retorno.status = false;
                    retorno.errors.Add("Id não pode ser nulo.");
                }
                
                
            }
            catch(Exception e) {
                retorno.status = false;
                retorno.errors.Append(e.Message);
                retorno.errors.Append(e.InnerException.ToString());
            }
            return retorno;
        }

        public RetornoGlobal<CatalogProjeto> getByID(int id){
            RetornoGlobal<CatalogProjeto> retorno = new RetornoGlobal<CatalogProjeto>();
            try
            {
                var registro = contexto.TabelaCatalogProjeto.Include(r=>r.ListaFotos).Where(r=>r.Id == id).FirstOrDefault();
                if(registro == null){
                    retorno.status = false;
                    retorno.errors.Add("Nenhum registro encontrado.");
                }
                else{
                    retorno.status = true;
                    retorno.RetornoObjeto = registro;
                }
            }
            catch(Exception e){
                retorno.status = false;
                retorno.errors.Append(e.Message);
                retorno.errors.Append(e.InnerException.ToString());
            }
            return retorno;
        }

        public RetornoGlobal<List<CatalogProjeto>> getPaginationProjects(ParameterPagination parameters){
            RetornoGlobal<List<CatalogProjeto>> retorno = new RetornoGlobal<List<CatalogProjeto>>();
            try
            {
                retorno.RetornoObjeto = contexto.TabelaCatalogProjeto.Include(r => r.ListaFotos).ToList().Skip(parameters.skip).Take(parameters.take).ToList();
                retorno.status = true;
            }
            catch(Exception e)
            {
                retorno.status = false;
                retorno.errors.Append(e.Message);
                retorno.errors.Append(e.InnerException.ToString());
            }
            return retorno;
        }


        /*
        public List<DataCardModel> getPaginationFotos(ParameterPagination parameters){
            return listaCards.Skip(parameters.skip).Take(parameters.take).ToList();
        }

        public DetailProject getDetailProjectByID(int idProjeto)
        {
            List<string> listaFotosProjeto = new List<string>();

            for(int i=0; i <= 18; i++){
                listaFotosProjeto.Add("https://picsum.photos/200/300");
            }
            
            return new DetailProject(){
                ListaGaleria = listaFotosProjeto,
                descriptionWork = new DescriptionBoxModel(){
                    title = "Titulo do projeto",
                    description = "Aqui vai uma breve explicação do projeto , podera ter espaço <br/><br/> ou qualquer outra lorota."
                }
            };
        }

*/



    }

}