using Application.Common.Exceptions;
using Application.Common.Interfaces;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.AuthorFeatures.Commands.DeleteAuthor
{
    public class DeleteAuthorCommandHandler : IRequestHandler<DeleteAuthorCommand, Guid>
    {
        private readonly ISchoolLibraryContext _context;

        public DeleteAuthorCommandHandler(ISchoolLibraryContext context)
        {
            _context = context;
        }


        public async Task<Guid> Handle(DeleteAuthorCommand command, CancellationToken cancellationToken)
        {
            var entity = await _context.Authors
                .AsNoTracking()
                .FirstOrDefaultAsync(a => a.AuthorId == command.Id, cancellationToken);

            if (entity == null) throw new NotFoundException(nameof(Author), command.Id);
                
            _context.Authors.Remove(entity);
            await _context.SaveChangesAsync(cancellationToken);
            return entity.AuthorId;
        }
    }
}