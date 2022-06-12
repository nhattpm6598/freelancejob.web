using freelancejob.business.Models.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freelancejob.business.Services.LoginService
{
    public interface ILoginService
    {
        Task<string> HandleLoginAccount(LoginRequest request);
    }
}
