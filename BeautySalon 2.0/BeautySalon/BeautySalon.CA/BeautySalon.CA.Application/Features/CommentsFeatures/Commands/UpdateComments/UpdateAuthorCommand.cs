using MediatR;

namespace Application.Features.AuthorFeatures.Commands.UpdateAuthor
{
    public class UpdateAuthorCommand : IRequest<Guid>
    {
        public Guid Id { get; set; } = default!;
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public DateTime Birthdate { get; set; } = default!;
        public string Nationality { get; set; } = default!;
    }
}