using System;
using System.Collections.Generic;

namespace freelancejob.data.Entities
{
    public partial class TblConvenant
    {
        public Guid Id { get; set; }
        public Guid? JobId { get; set; }
        public string ContentRequest { get; set; }
        public int? BudgetRequest { get; set; }
        public int? Status { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdateAt { get; set; }
    }
}
