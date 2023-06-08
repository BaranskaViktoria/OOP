using BeautySalon.CA.Application.Common.Pagging.Entities;
using BeautySalon.CA.Application.Features.CommentsFeatures.Queries.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon.CA.Application.Features.CommentsFeatures.Queries.GetAllComment_DataShaping
{
    public class GetAllCommentsProductsQuery : IRequest<IEnumerable<CommentDTO>>
    {
        public CommentsProductsParameter _parameters { get; }

        public GetAllCommentsProductsQuery(CommentsProductsParameter parameters)
        {
            _parameters = parameters;
        }
    }
}
