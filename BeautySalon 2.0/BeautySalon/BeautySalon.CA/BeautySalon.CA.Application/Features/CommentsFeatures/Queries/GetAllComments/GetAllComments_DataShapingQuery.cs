using Application.Common.HATEOS;
using BeautySalon.CA.Application.Common.Pagging.Entities;
using MediatR;
using Microsoft.VisualStudio.Services.WebApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon.CA.Application.Features.CommentsFeatures.Queries.GetAllComments
{
    public class GetAllComments_DataShapingQuery : IRequest<PagedList<ShapedEntity>>
    {
        public CommentsParameter _parameters { get; }

        public GetAllComments_DataShapingQuery(CommentsParameter parameters)
        {
            _parameters = parameters;
        }
    }
}
