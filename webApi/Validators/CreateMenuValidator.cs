using System;
using System.Linq;
using Commands;
using Contexto;
using FluentValidation;
using webApi.Models;

namespace webApi.Validators {
    public class CreateMenuValidator : AbstractValidator<CreateMenuCommand>{

        public CreateMenuValidator(ContextoDB context){

            // Descricao Botão 
            RuleFor(r => r.description).NotNull().WithMessage("Descrição botão não pode ser nulo.");
            RuleFor(r => r.description).NotEmpty().WithMessage("Descrição botão não pode ser vazio.");
            
            // Senha Botão
            RuleFor(r => r.href).NotNull().WithMessage("Href não pode ser nulo.");
            RuleFor(r => r.href).NotEmpty().WithMessage("Href não pode ser vazio.");

            // Verifica cadastro igual
            RuleFor(r=> r.description).Custom((descricao, contexto) => {
                if(!string.IsNullOrEmpty(descricao)){
                    var registro = context.TabelaButtonsMenu.Where(r => r.description == descricao).FirstOrDefault();
                    if(registro != null){
                        contexto.AddFailure("Descrição já existe no sistema.");
                    }
                }
            });

        }

    }
} 