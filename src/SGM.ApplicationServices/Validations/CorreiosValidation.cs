using FluentValidation;
using SGM.Domain.Entities.External;

namespace SGM.ApplicationServices.Validations
{
    public class CorreiosValidation : AbstractValidator<CorreiosEndereco>
    {
        public CorreiosValidation()
        {
            RuleFor(input => input.Logradouro)
                .NotEmpty()
                .NotNull()
                .WithMessage("O Logradouro está vazio.");
        }
    }
}