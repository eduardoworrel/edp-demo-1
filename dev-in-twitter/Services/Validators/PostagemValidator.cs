using FluentValidation;
using Domain.Entities;

namespace Services.Validators;
public class PostagemValidator : AbstractValidator<Postagem>
{
    public PostagemValidator()
    {
        RuleFor(c => c.NomeUsuario)
            .NotEmpty().WithMessage("Nome invalido.")
            .NotNull().WithMessage("Nome invalido.");

        RuleFor(c => c.ConteudoPublicado)
            .NotEmpty().WithMessage("Post sem conteúdo.")
            .NotNull().WithMessage("Post sem conteúdo")
            .GreaterThanOrEqualTo("140").WithMessage("Post a cima do limite");                

        RuleFor(c => c.DataHoraPublicacao)
            .NotEmpty().WithMessage("Data invalida.")
            .NotNull().WithMessage("Data invalida.");
    }
}