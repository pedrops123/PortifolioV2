using System;
using System.Linq;
using Commands;
using Contexto;
using FluentValidation;

namespace webApi.Validators{
    public class UpdateMenuValidator : AbstractValidator<UpdateMenuCommand> {

        public UpdateMenuValidator(ContextoDB context){
            
            RuleFor(r => r.Id).NotNull().WithMessage("Id não pode ser nulo.");
            RuleFor(r => r.Id).NotEmpty().WithMessage("Id não pode ser vazio.");
            

            // Descricao Botão 
            RuleFor(r => r.description).NotNull().WithMessage("Descrição botão não pode ser nulo.");
            RuleFor(r => r.description).NotEmpty().WithMessage("Descrição botão não pode ser vazio.");
            
            // Senha Botão
            RuleFor(r => r.href).NotNull().WithMessage("Href não pode ser nulo.");
            RuleFor(r => r.href).NotEmpty().WithMessage("Href não pode ser vazio.");

            // Verifica cadastro igual
            RuleFor(r => r).Custom((objeto, contexto) => {
                if(!string.IsNullOrEmpty(objeto.description)){
                    var registro = context.TabelaButtonsMenu.Where(r => r.description == objeto.description && r.Id != objeto.Id ).FirstOrDefault();
                    if(registro != null){
                        contexto.AddFailure("Descrição já existe no sistema.");
                    }
                }
            });

        }

    }
}