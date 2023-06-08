using Application.Common.Mapping.Mapster;
using BeautySalon.CA.Application.Common.Interfaces;
using BeautySalon.CA.Application.Features.CommentsFeatures.Queries.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon.CA.Application.Features.CommentsFeatures.Queries.GetAllComments
{
    public class GetAllComments_DataShapingQueryHandler : IRequestHandler<GetAllComments_DataShapingQuery, IEnumerable<CommentDTO>>
    {
        private readonly IBeautySalonContext _context;
        private readonly ISortHelper<CommentDetails> _sortHelper;

        public GetAllBookDetailsQueryHandler(IBeautySalonContext context, ISortHelper<BookDetails> sortHelper)
        {
            _context = context;
            _sortHelper = sortHelper;
        }


        public async Task<IEnumerable<CommentsDTO>> Handle
            (GetAllBookDetailsQuery query, CancellationToken cancellationToken)
        {
            var list = _context.CommentDetails.AsNoTracking();

            // Sorting
            list = _sortHelper.ApplySort(list, query._parameters.OrderBy);

            // Paging
            return await MapsterFunctions.MapListSourceToDestination<BookDetails, BookDetailsDTO>(
                list
                    //.OrderBy(bd => bd.BookDetailId)
                    .Skip((query._parameters.PageNumber - 1) * query._parameters.PageSize)
                    .Take(query._parameters.PageSize)
                    .Include(bd => bd.Book))
                .ToListAsync(cancellationToken);
        }
    }
}
