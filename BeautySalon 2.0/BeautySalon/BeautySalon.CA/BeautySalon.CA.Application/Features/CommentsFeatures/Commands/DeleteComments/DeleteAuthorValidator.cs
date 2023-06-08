using FluentValidation;

namespace Application.Features.AuthorFeatures.Commands.DeleteAuthor
{
    public sealed class DeleteAuthorValidator : AbstractValidator<DeleteAuthorCommand>
    {
        public DeleteAuthorValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty().WithMessage("Id is required");
        }
    }
}