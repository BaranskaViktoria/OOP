using Application.Common.Interfaces;
using Application.Common.Mapping.Mapster;
using Domain.Entities;
using MediatR;

namespace Application.Features.AuthorFeatures.Commands.CreateAuthor
{
    public class CreateCommentsCommandHandler : IRequestHandler<CreateCommentsCommand, Guid>
    {
        private readonly ISchoolLibraryContext _context;

        public CreateCommentsCommandHandler(ISchoolLibraryContext context)
        {
            _context = context;
        }


        public async Task<Guid> Handle(CreateCommentsCommand command, CancellationToken cancellationToken)
        {
            var entity = MapsterFunctions.MapSourceToDestination<CreateCommentsCommand, Author>(command);

            await _context.Authors.AddAsync(entity, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
            return entity.AuthorId;
        }
    }
}