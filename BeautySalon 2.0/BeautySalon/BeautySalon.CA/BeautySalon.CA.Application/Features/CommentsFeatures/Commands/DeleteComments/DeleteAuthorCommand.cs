using MediatR;

namespace Application.Features.AuthorFeatures.Commands.DeleteAuthor
{
    public class DeleteAuthorCommand : IRequest<Guid>
    {
        public Guid Id { get; set; } = default!;
    }
}