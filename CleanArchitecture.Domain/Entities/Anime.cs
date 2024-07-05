using CleanArchitecture.Domain.Common;
using CleanArchitecture.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Entities
{
    public sealed class Anime : BaseEntity
    {
        public string? Name { get; set; }
        public string? Synopsis { get; set; }
        public float? Score { get; set; }
        public int? Episodes { get; set; }
        public string? Studio { get; set; }
        public AnimeStatus? Status { get; set; }
        public DateTimeOffset? DateAired { get; set; }
    }
}
