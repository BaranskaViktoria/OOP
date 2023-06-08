using MediatR;

namespace Application.Features.AuthorFeatures.Commands.UpdateAuthor
{
    public class UpdateCommentsCommand : IRequest<Guid>
    {
        public Guid Id { get; set; } = default!;
        public int UserID { get; set; } = default!;
        public int MasterID { get; set; } = default!;
        public decimal Rating { get; set; } = default!;
        public DateTime CreateTime { get; set; } = default!;
        public string? Comment { get; set; } = default!;

    }
}