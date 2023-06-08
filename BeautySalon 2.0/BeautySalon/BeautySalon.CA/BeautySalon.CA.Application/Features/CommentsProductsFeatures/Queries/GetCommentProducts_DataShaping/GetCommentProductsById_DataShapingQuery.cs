using System.Dynamic;
using Application.Common.HATEOS;
using BeautySalon.CA.Application.Common.Pagging.Entities;
using MediatR;

namespace Application.Features.BookFeatures.Queries.GetBook_DataShaping
{
    public class GetCommentProductsById_DataShapingQuery : IRequest<ShapedEntity>
    {
        public Guid Id { get; set; } = default!;
        public CommentsParameter _parameters { get; }

        public GetCommentProductsById_DataShapingQuery(CommentsParameter parameters)
        {
            _parameters = parameters;
        }
    }
}