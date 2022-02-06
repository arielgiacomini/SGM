using FluentValidation;
using SGM.Domain.Entities;

namespace SGM.ApplicationServices.Validations
{
    public class ClienteValidation : AbstractValidator<Cliente>
    {
        public ClienteValidation()
        {
            RuleFor(input => input.NomeCliente)
                .NotEmpty()
                .NotNull()
                .WithMessage("O nome do cliente não pode ser nulo ou vazio.");
        }
    }
}