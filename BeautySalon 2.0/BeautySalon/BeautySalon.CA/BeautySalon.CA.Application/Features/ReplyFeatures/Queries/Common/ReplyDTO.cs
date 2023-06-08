using Application.Common.HATEOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon.CA.Application.Features.ReplyFeatures.Queries.Common
{
    public class ReplyDTO : LinkBaseEntity
    {
        public int Id { get; set; }
        public int CommentId { get; set; } = default!;
        public string? TextPeply { get; set; } = default!;
        public DateTime DateTimeReply { get; set; }
    }
}
