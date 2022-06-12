using freelancejob.business.Enums.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freelancejob.business.Models.Dtos
{
    public class AccountDto
    {
        public Guid Id { get; set; }

        public string UserName { get; set; }  
        
        public string Email { get; set; }

        public string FullName { get; set; }

        public RoleAccount RoleAccount { get; set; }
    }
}
