using FluentValidation;

namespace Application.Features.AuthorFeatures.Commands.CreateAuthor
{
    public sealed class CreateCommentsValidator : AbstractValidator<CreateCommentsCommand>
    {
        public CreateCommentsValidator()
        {
            RuleFor(x => x.FirstName)
                .NotNull()
                .NotEmpty()
                .MaximumLength(50)
                .WithMessage("The first name must not be empty, and must not exceed 50 characters in length");
            
            RuleFor(x => x.LastName)
                .NotNull()
                .NotEmpty()
                .MaximumLength(50)
                .WithMessage("The last name must not be empty, and must not exceed 50 characters in length");
            
            RuleFor(x => x.Birthdate)
                .NotEmpty().WithMessage("Birth date is required")
                .Must(ValidDate).WithMessage("Invalid date format");
            
            RuleFor(x => x.Nationality)
                .NotNull()
                .NotEmpty()
                .MaximumLength(30)
                .WithMessage("The nationality must not be empty, and must not exceed 30 characters in length");
        }

        private static bool ValidDate(DateTime date)
        {
            return !date.Equals(default(DateTime)) && date < DateTime.Now;
        }
    }
}