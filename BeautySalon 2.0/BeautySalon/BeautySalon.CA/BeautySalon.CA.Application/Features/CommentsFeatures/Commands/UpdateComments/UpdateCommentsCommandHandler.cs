using Application.Common.Exceptions;

using Application.Common.Mapping.Mapster;
using BeautySalon.CA.Application.Common.Interfaces;
using BeautySalon.CA.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.AuthorFeatures.Commands.UpdateAuthor
{
    public class UpdateCommentsCommandHandler : IRequestHandler<UpdateCommentsCommand, Guid>
    {
        private readonly IBeautySalonContext _context;

        public UpdateCommentsCommandHandler(IBeautySalonContext context)
        {
            _context = context;
        }


        public async Task<Guid> Handle(UpdateCommentsCommand command, CancellationToken cancellationToken)
        {
         
            var entity = await _context.Comments
                .AsNoTracking()
                .FirstOrDefaultAsync(a => a.Id = command.Id, cancellationToken);
                
            if (entity == null) throw new NotFoundException(nameof(Comments), command.Id);
                
            entity = MapsterFunctions.MapSourceToDestination<UpdateCommentsCommand,Comments>(command);
            
            _context.Comments.Update(entity);
            await _context.SaveChangesAsync(cancellationToken);
            return entity.AuthorId;
        }
    }
}