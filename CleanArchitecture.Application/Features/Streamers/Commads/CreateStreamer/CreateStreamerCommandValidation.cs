
using FluentValidation;

namespace CleanArchitecture.Application.Features.Streamers.Commads.CreateStreamer
{
    public class CreateStreamerCommandValidation : AbstractValidator<CreateStreamerCommand>
    {
        public CreateStreamerCommandValidation()
        {
            RuleFor(p => p.Nombre)
                .NotEmpty().WithMessage("{Nombre} no puede estar vacio")
                .NotNull()
                .MaximumLength(50).WithMessage("El nombre no puede exceder los 50 caracteres");

            RuleFor(p => p.Url)
                .NotEmpty().WithMessage("La {Url} no puede estar en blanco");
        }
    }
}
