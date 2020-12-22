
using System;
using System.Linq;
using Commands;
using Contexto;
using FluentValidation;

namespace webApi.Validators {
    public class CreateCatalogValidator : AbstractValidator<CreateCatalogProjeto> {
        public CreateCatalogValidator(ContextoDB contexto) {

            // Nome do projeto
            RuleFor(r=>r.nome_projeto).NotEmpty().WithMessage("Nome do projeto não pode ficar em branco.");
            RuleFor(r=>r.nome_projeto).NotNull().WithMessage("Nome do projeto não pode ser nulo.");

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
            RuleFor(r => r.ListaFotos ).Custom((fotos , context) => {
                int tamanhoLista = fotos.Count;
                if(tamanhoLista == 0){
                        context.AddFailure("Incluir pelo menos 1 foto no projeto.");
                }
            });

            // Verifica nome de projeto igual
            RuleFor(r=>r.nome_projeto).Custom((nome ,context ) =>{
                if(!String.IsNullOrEmpty(nome)){
                    var registro = contexto.TabelaCatalogProjeto.Where(r=>r.nome_projeto.Trim().ToLower() == nome.Trim().ToLower()).FirstOrDefault();
                    if(registro != null){
                        context.AddFailure("Já existe um projeto com o mesmo nome.");
                    }
                }
            });




        }
        
    }

}