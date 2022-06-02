using System;
using System.Collections.Generic;

#nullable disable

namespace freelancejob.data.Entities
{
    public partial class TblJob
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string SkillExpertise { get; set; }
        public int? Budget { get; set; }
        public Guid? Creator { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool? IsActive { get; set; }
    }
}
