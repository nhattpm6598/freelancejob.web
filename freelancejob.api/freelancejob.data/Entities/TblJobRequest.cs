using System;
using System.Collections.Generic;

namespace freelancejob.data.Entities
{
    public partial class TblJobRequest
    {
        public Guid JobId { get; set; }
        public int SkillId { get; set; }
    }
}
