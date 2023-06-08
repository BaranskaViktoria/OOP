using AutoMapper;
using BeautySalon.CA.Application.Interfaces.Repositories;
using BeautySalon_EF.DAL.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.ObjectMapping;

namespace BeautySalon.CA.Application.Features.CommentsProductsFeatures.Commands.CreateCommentsProducts
{
    public record CreateCommentsProductaCommand : IRequest<Result<int>>, IMapFrom<CommentsProducts>
    {
        public int  UserID { get; set; }
        public int ProductID { get; set; }
        public decimal Rating { get; set; }

        public DateTime CreateTime { get; set; }
        public string Comments { get; set; }
    }

    internal class CreatePlayerCommandHandler : IRequestHandler<CreateCommentsProductaCommand, Result<int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreatePlayerCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Result<int>> Handle(CreateCommentsProductaCommand command, CancellationToken cancellationToken)
        {
            var commentsProduct = new CommentsProducts ()
            {
                UserID = command.UserID,
                ProductID = command.ProductID,
                Rating = command.Rating,
                CreateTime = command.CreateTime,
                Comments = command.Comments,
            };

            await _unitOfWork.Repository<CommentsProducts>().AddAsync(commentsProduct);
            commentsProduct.AddDomainEvent(new CommentsProductsCreatedEvent(commentsProduct));
            await _unitOfWork.Save(cancellationToken);
            return await Result<int>.SuccessAsync(commentsProduct.Id, "CommentProduct Created.");
        }
    }
}
