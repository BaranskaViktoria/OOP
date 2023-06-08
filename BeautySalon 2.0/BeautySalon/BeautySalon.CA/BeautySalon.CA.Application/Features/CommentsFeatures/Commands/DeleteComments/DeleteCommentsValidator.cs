using FluentValidation;

namespace Application.Features.AuthorFeatures.Commands.DeleteAuthor
{
    public sealed class DeleteCommentsValidator : AbstractValidator<DeleteCommentsCommand>
    {
        public DeleteCommentsValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty().WithMessage("Id is required");
        }
    }
}