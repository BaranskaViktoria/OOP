using BeautySalon.CA.Application.Features.CommentsFeatures.Queries.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon.CA.Application.Features.CommentsFeatures.Queries.GetComment
{
    public class GetCommentByIdQuery : IRequest<CommentDTO>
    {
        public Guid Id { get; set; } = default!;
    }
}
