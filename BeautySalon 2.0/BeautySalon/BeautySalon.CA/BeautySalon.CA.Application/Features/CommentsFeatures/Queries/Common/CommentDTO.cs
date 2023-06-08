using Application.Common.HATEOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon.CA.Application.Features.CommentsFeatures.Queries.Common
{
    public class CommentDTO : LinkBaseEntity
    {
        public int Id { get; set; }
        public int UserID { get; set; } = default!;
        public int MasterID { get; set; } = default!;
        public decimal Rating { get; set; } = default!;
        public DateTime CreateTime { get; set; }
        public string? Comment { get; set; } = default!;
    }
}
