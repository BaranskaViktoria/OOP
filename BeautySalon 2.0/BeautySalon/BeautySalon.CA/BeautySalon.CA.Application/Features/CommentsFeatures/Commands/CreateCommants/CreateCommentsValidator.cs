using FluentValidation;

namespace Application.Features.AuthorFeatures.Commands.CreateAuthor
{
    public sealed class CreateCommentsValidator : AbstractValidator<CreateCommentsCommand>
    {
        public CreateCommentsValidator()
        {
            RuleFor(x => x.CreateTime)
                .NotEmpty().WithMessage("Birth date is required")
                .Must(ValidDate).WithMessage("Invalid date format");
            
            RuleFor(x => x.Comment)
                .MaximumLength(50)
                .WithMessage("The Comment  must not be empty, and must not exceed 50 characters in length");
        }

        private static bool ValidDate(DateTime date)
        {
            return !date.Equals(default(DateTime)) && date < DateTime.Now;
        }
    }
}