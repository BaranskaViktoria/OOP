
using Application.Common.Mapping.Mapster;
using Application.Features.AuthorFeatures.Commands.CreateAuthor;
using BeautySalon.CA.Application.Common.Interfaces;
using BeautySalon.CA.Domain.Entities;
using MediatR;

namespace Application.Features.AuthorFeatures.Commands.CreateComments
{
    public class CommentCreatedHandler : IRequestHandler<CreateCommentsCommand, Guid>
    {
        private readonly IBeautySalonContext _context;

        public CommentCreatedHandler(IBeautySalonContext context)
        {
            _context = context;
        }


        public async Task<Guid> Handle(CreateCommentsCommand command, CancellationToken cancellationToken)
        {
            var entity = MapsterFunctions.MapSourceToDestination<CreateCommentsCommand, Comments>(command);

            await _context.Comments.AddAsync(entity, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
            return entity.Id;
        }
    }
}