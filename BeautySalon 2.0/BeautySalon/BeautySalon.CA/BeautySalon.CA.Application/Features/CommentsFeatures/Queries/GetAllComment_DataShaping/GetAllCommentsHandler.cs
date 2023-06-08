using Application.Common.Mapping.Mapster;
using BeautySalon.CA.Application.Common.Interfaces;
using BeautySalon.CA.Application.Features.CommentsFeatures.Queries.Common;
using BeautySalon.CA.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon.CA.Application.Features.CommentsFeatures.Queries.GetAllComment_DataShaping
{
    public class GetAllCommentsQueryHandler : IRequestHandler<GetAllCommentsProductsQuery, IEnumerable<CommentDTO>>
    {
        private readonly IBeautySalonContext _context;
        private readonly ISortHelper<Comments> _sortHelper;


        public GetAllCommentsQueryHandler(IBeautySalonContext context, ISortHelper<Comments> sortHelper)
        {
            _context = context;
            _sortHelper = sortHelper;
        }
        public async Task<IEnumerable<CommentDTO>> Handle(GetAllCommentsProductsQuery query, CancellationToken cancellationToken)
        {
            var list = _context.Comments.AsNoTracking();

            // Sorting
            list = _sortHelper.ApplySort(list, query._parameters.OrderBy);

            // Paging
            return await MapsterFunctions.MapListSourceToDestination<Comments, CommentDTO>(
                list
                    //.OrderBy(b => b.CommentProductsId)
                    .Skip((query._parameters.PageNumber - 1) * query._parameters.PageSize)
                    .Take(query._parameters.PageSize)
            .ToListAsync(cancellationToken);
        }
    }
}

