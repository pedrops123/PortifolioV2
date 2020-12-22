using System;
using System.Linq;
using Commands;
using Contexto;
using FluentValidation;

namespace webApi.Validators{

    public class UpdateCatalogValidator : AbstractValidator<UpdateCatalogProjeto>{

           public UpdateCatalogValidator(ContextoDB contexto){

            // id do projeto
            RuleFor(r=>r.Id).NotNull().WithMessage("Id do projeto não pode ser nulo.");

            //  thumbnail 
            RuleFor(r=>r.img_thumbnail).NotEmpty().WithMessage("Img Thumbnail não pode ficar em branco.");
            RuleFor(r=>r.img_thumbnail).NotNull().WithMessage("Img Thumbnail não pode ser nulo.");

            //  descritivo capa 
            RuleFor(r=>r.descritivo_capa).NotEmpty().WithMessage("Descritivo da capa não pode ficar em branco.");
            RuleFor(r=>r.descritivo_capa).NotNull().WithMessage("Descritivo da capa não pode ser nulo.");

             //  texto projeto (descricao do projeto) 
            RuleFor(r => r.texto_projeto).NotEmpty().WithMessage("Texto do projeto não pode ficar em branco.");
            RuleFor(r => r.texto_projeto).NotNull().WithMessage("Texto do projeto não pode ser nulo.");

            // Regras customizadas 

            // Verifica lista de fotos 
            RuleFor(r => r ).Custom((objeto , context) => {
                if(objeto.Id != null && objeto.Id != 0){
                    var qtdFotosCadastradas = contexto.TabelaFotosProjeto.Where(r=>r.IdProjeto == objeto.Id).ToList();
                    if(qtdFotosCadastradas.Count() == 0){
                        if(objeto.ListaFotos != null){
                            int qtdFotosLista = objeto.ListaFotos.Count();
                            if(qtdFotosLista == 0){
                                context.AddFailure("Incluir pelo menos 1 foto no projeto.");
                            }
                        }
                    }
                }
            });

            RuleFor(r=>r.Id).Custom((id , context)=>{
                if(id != null){
                    if(id == 0){
                        context.AddFailure("Id do projeto nao pode ser igual a 0");
                    }
                    else{
                        var verificaRegistro = contexto.TabelaCatalogProjeto.Where(r=>r.Id == id).FirstOrDefault();
                        if(verificaRegistro == null){
                            context.AddFailure("Registro não existente.");
                        }
                    }
                }
            });
            

           } 

    }

}