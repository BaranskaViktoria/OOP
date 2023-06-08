using Application.Common.Exceptions;
using Application.Common.Mapping.Mapster;
using BeautySalon.CA.Application.Common.Interfaces;
using BeautySalon.CA.Application.Features.CommentsFeatures.Queries.Common;
using BeautySalon.CA.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon.CA.Application.Features.CommentsFeatures.Queries.GetComment
{
    public class GetCommentByIdQueryHandler : IRequestHandler<GetCommentByIdQuery, CommentDTO>
    {
        private readonly IBeautySalonContext _context;

        public GetCommentByIdQueryHandler(IBeautySalonContext context)
        {
            _context = context;
        }


        public async Task<CommentDTO> Handle(GetCommentByIdQuery query, CancellationToken cancellationToken)
        {
            var entity = MapsterFunctions.MapSourceToDestination<Comments, CommentDTO>(await _context.Comments
                .AsNoTracking()
                .Include(b => b.Publisher)
                .FirstAsync(b => b.CommentsId == query.Id, cancellationToken: cancellationToken));

            return entity ?? throw new NotFoundException(nameof(Comments), query.Id);
        }

    }
}

