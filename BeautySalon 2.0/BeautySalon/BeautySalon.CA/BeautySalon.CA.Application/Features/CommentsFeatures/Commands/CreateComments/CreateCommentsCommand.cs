using MediatR;

namespace Application.Features.AuthorFeatures.Commands.CreateAuthor
{
    public class CreateCommentsCommand : IRequest<Guid>
    {
        public int UserID { get; set; } = default!;
        public int MasterID { get; set; } = default!;
        public decimal Rating { get; set; } = default!;
        public DateTime CreateTime { get; set; } = default!;
        public string? Comment { get; set; } = default!;
    }
}