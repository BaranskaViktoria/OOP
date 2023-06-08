using Application.Common.Mapping.Mapster;
using BeautySalon.CA.Application.Common.Interfaces;
using BeautySalon.CA.Application.Features.CommentsFeatures.Queries.Common;
using BeautySalon.CA.Application.Features.CommentsProductsFeatures.Queries.Common;
using BeautySalon.CA.Domain.Entities;
using BeautySalon_EF.DAL.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon.CA.Application.Features.CommentsFeatures.Queries.GetAllComment_DataShaping
{
    public class GetAllCommentsProductsHandler : IRequestHandler<GetAllCommentsProductsQuery, IEnumerable<CommentsProductsDTO>>
    {
        private readonly IBeautySalonContext _context;
        private readonly ISortHelper<CommentsProducts> _sortHelper;


        public GetAllCommentsProductsHandler(IBeautySalonContext context, ISortHelper<Comments> sortHelper)
        {
            _context = context;
            _sortHelper = sortHelper;
        }
        public async Task<IEnumerable<CommentsProductsDTO>> Handle(GetAllCommentsProductsQuery query, CancellationToken cancellationToken)
        {
            var list = _context.CommentsProducts.AsNoTracking();

            // Sorting
            list = _sortHelper.ApplySort(list, query._parameters.OrderBy);

            // Paging
            return await MapsterFunctions.MapListSourceToDestination<CommentsProducts, CommentsProductsDTO>(
                list
                    //.OrderBy(b => b.CommentProductsId)
                    .Skip((query._parameters.PageNumber - 1) * query._parameters.PageSize)
                    .Take(query._parameters.PageSize)
            .ToListAsync(cancellationToken);
        }
    }
}

