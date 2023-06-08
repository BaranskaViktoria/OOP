
using Application.Common.Exceptions;
using BeautySalon.CA.Application.Common.Interfaces;
using BeautySalon.CA.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.AuthorFeatures.Commands.DeleteAuthor
{
    public class DeleteCommentsCommandHandler : IRequestHandler<DeleteCommentsCommand, Guid>
    {
        private readonly IBeautySalonContext _context;

        public DeleteCommentsCommandHandler(IBeautySalonContext context)
        {
            _context = context;
        }


        public async Task<Guid> Handle(DeleteCommentsCommand command, CancellationToken cancellationToken)
        {
            var entity = await _context.Comments
                .AsNoTracking()
                .FirstOrDefaultAsync(a => GetId(a) == command.Id, cancellationToken);

            if (entity == null) throw new NotFoundException(nameof(Comments), command.Id);

            _context.Comments.Remove(entity);
            await _context.SaveChangesAsync(cancellationToken);
            return entity.AuthorId;
        }

        private static int GetId(Comments a)
        {
            return a.Id;
        }
    }
}