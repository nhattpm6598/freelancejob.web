using System;
using System.Collections.Generic;

#nullable disable

namespace freelancejob.data.Entities
{
    public partial class TblUser
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string ImageUrl { get; set; }
        public string PhoneNumber { get; set; }
        public string Major { get; set; }
        public int? Role { get; set; }
        public string SkillExpertise { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public int? Wallet { get; set; }
        public string Languages { get; set; }
        public string Verifications { get; set; }
        public int? HoursPerWeek { get; set; }
        public int? CostPerWeek { get; set; }
    }
}
