using MediatR;

namespace Application.Features.AuthorFeatures.Commands.DeleteAuthor
{
    public class DeleteCommentsCommand : IRequest<Guid>
    {
        public Guid Id { get; set; } = default!;
    }
}