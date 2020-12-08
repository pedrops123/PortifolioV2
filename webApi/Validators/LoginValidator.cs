using System;
using FluentValidation;
using webApi.Models;

namespace webApi.Validators {
    public class LoginValidator : AbstractValidator<LoginModel>{

        public LoginValidator(){

            // Login
            RuleFor(r => r.login).NotNull().WithMessage("Login não pode ser nulo.");
            RuleFor(r => r.login).NotEmpty().WithMessage("Login não pode ser vazio.");
            
            // Senha
            RuleFor(r => r.senha).NotNull().WithMessage("Senha não pode ser nulo.");
            RuleFor(r => r.senha).NotEmpty().WithMessage("Senha não pode ser vazia.");
        }

    }
} 