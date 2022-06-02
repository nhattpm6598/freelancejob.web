using freelancejob.business.Services.Abstractions;
using freelancejob.data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freelancejob.business.Services
{
    public class UserService : IUserService
    {
        private readonly FreelanceJobContext _freelanceJobContext;

        public UserService(FreelanceJobContext freelanceJobContext)
        {
            _freelanceJobContext = freelanceJobContext;
        }

        public async Task<TblUser> LoginAccount(string username, string password)
        {
            if(username == null || password == null)
            {
                return null;
            }

            return await _freelanceJobContext.TblUsers
                .Where(x => x.Username == username && x.Password == password)
                .FirstOrDefaultAsync()
                .ConfigureAwait(false);

        }
    }
}
