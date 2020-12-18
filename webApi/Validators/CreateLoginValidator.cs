using System;
using System.Linq;
using Commands;
using Contexto;
using FluentValidation;
using webApi.Models;

namespace webApi.Validators {

    public class CreateLoginValidator : AbstractValidator<CreateLoginCommand> {

        public CreateLoginValidator(ContextoDB contexto){

            // Login
            RuleFor(r => r.Login).NotNull().WithMessage("Login não pode ser nulo.");
            RuleFor(r => r.Login).NotEmpty().WithMessage("Login não pode ser vazio.");
            
            // Senha
            RuleFor(r => r.Senha).NotNull().WithMessage("Senha não pode ser nulo.");
            RuleFor(r => r.Senha).NotEmpty().WithMessage("Senha não pode ser vazia.");

            // tipo Acesso   
            RuleFor(r => r.UsuarioAcessoId).NotNull().WithMessage("Tipo Acesso não pode ser nulo.");

            RuleFor(r => r.UsuarioAcessoId).Custom((idAcesso,context)=>{
                if(idAcesso == 0){
                     context.AddFailure("Acesso não pode ser 0");
                }
            });

            RuleFor(r => r.UsuarioAcessoId).Custom(( idacesso, context ) => {
                if(idacesso != 0){
                    var registro = contexto.TabelaAcessos.Where(f => f.Id == idacesso).FirstOrDefault();
                    if(registro == null){
                        context.AddFailure("Acesso não existente.");
                    }
                }
            });

            // Valida login igual

            RuleFor(r=> r.Login).Custom((login ,context) => {
                if(login != null){
                      var usuario = contexto.TabelaUsuarios.Where(r=>r.Login == login).FirstOrDefault();
                        if(usuario != null){
                              context.AddFailure("O usuario ja existe no sistema");
                        }
                }
            });

        }

    }
}
