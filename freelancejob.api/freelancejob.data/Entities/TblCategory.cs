using System;
using System.Collections.Generic;

namespace freelancejob.data.Entities
{
    public partial class TblCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? ParentId { get; set; }
    }
}
