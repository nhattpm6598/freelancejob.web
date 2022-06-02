using freelancejob.data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freelancejob.business.Services.Abstractions
{
    public interface IUserService
    {
        /// <summary>
        /// login account
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        Task<TblUser> LoginAccount(string username, string password);
    }
}
