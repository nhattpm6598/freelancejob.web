using System;
using System.Collections.Generic;

#nullable disable

namespace freelancejob.data.Entities
{
    public partial class TblReport
    {
        public Guid Id { get; set; }
        public Guid? ConvenantId { get; set; }
        public Guid? JobId { get; set; }
        public string Content { get; set; }
        public int? Status { get; set; }
        public Guid? Creator { get; set; }
        public DateTime? CreatedAt { get; set; }
        public Guid? UpdateBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
