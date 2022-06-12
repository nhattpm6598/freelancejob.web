using System;
using System.Collections.Generic;

namespace freelancejob.data.Entities
{
    public partial class TblSkillExpertise
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? CategoryId { get; set; }
    }
}
