using System;
using System.Collections.Generic;

#nullable disable

namespace freelancejob.data.Entities
{
    public partial class TblUserSkill
    {
        public Guid UserId { get; set; }
        public int SkillId { get; set; }
    }
}
