using Application.Common.Exceptions;
using Application.Common.Interfaces;
using Application.Common.Mapping.Mapster;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.AuthorFeatures.Commands.UpdateAuthor
{
    public class UpdateAuthorCommandHandler : IRequestHandler<UpdateAuthorCommand, Guid>
    {
        private readonly ISchoolLibraryContext _context;

        public UpdateAuthorCommandHandler(ISchoolLibraryContext context)
        {
            _context = context;
        }


        public async Task<Guid> Handle(UpdateAuthorCommand command, CancellationToken cancellationToken)
        {
            var entity = await _context.Authors
                .AsNoTracking()
                .FirstOrDefaultAsync(a => a.AuthorId == command.Id, cancellationToken);
                
            if (entity == null) throw new NotFoundException(nameof(Author), command.Id);
                
            entity = MapsterFunctions.MapSourceToDestination<UpdateAuthorCommand, Author>(command);
            
            _context.Authors.Update(entity);
            await _context.SaveChangesAsync(cancellationToken);
            return entity.AuthorId;
        }
    }
}