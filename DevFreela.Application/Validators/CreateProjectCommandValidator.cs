using DevFreela.Application.Commands.CreateProject;
using FluentValidation;

namespace DevFreela.Application.Validators
{
    public class CreateProjectCommandValidator : AbstractValidator<CreateProjectCommand>
    {
        public CreateProjectCommandValidator()
        {
            RuleFor(p => p.Description)
                .NotEmpty()
                .MinimumLength(30)
                .WithMessage("Tamanho mínimo de Descrição é de 30 caracteres.")
                .MaximumLength(255)
                .WithMessage("Tamanho máximo de Descrição é de 255 caracteres.");

            RuleFor(p => p.Title)
                .NotEmpty()
                .WithMessage("Título é obrigatório.")
                .MaximumLength(30)
                .WithMessage("Tamanho máximo de Título é de 30 caracteres.");
        }
    }
}
