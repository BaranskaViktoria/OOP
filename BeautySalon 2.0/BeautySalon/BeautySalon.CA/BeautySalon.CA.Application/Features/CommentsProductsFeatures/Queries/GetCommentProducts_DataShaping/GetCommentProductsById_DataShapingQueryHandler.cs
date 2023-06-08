using System.Dynamic;
using Application.Common.Exceptions;
using Application.Common.HATEOS;

using BeautySalon.CA.Application.Common.Interfaces;
using BeautySalon.CA.Domain.Entities;

using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.BookFeatures.Queries.GetBook_DataShaping
{
    public class GetCommentProductsById_DataShapingQueryHandler : IRequestHandler<GetCommentProductsById_DataShapingQuery, ShapedEntity>
    {
        private readonly IBeautySalonContext _context;
        private readonly IDataShaper<Comments> _dataShaper;

        public GetCommentProductsById_DataShapingQueryHandler(
            IBeautySalonContext context, 
            IDataShaper<Comments> dataShaper)
        {
            _context = context;
            _dataShaper = dataShaper;
        }


        public async Task<ShapedEntity> Handle
            (GetCommentProductsById_DataShapingQuery query, CancellationToken cancellationToken)
        {
            var entity = await _context.Comments
                .AsNoTracking()
                .Include(b => b.Publisher)
                .FirstAsync(bd => bd.CommentId == query.Id, cancellationToken);
                
            return entity == null ? 
                throw new NotFoundException(nameof(Comments), query.Id) :
                _dataShaper.ShapeData(entity, query._parameters.Fields ?? "");
        }
    }
}