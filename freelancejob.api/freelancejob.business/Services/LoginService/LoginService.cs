using freelancejob.business.Enums.Reasons;
using freelancejob.business.Enums.Types;
using freelancejob.business.Exceptions;
using freelancejob.business.Helper;
using freelancejob.business.Models.Dtos;
using freelancejob.business.Models.Requests;
using freelancejob.business.Options;
using freelancejob.data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freelancejob.business.Services.LoginService
{
    public class LoginService : ILoginService
    {
        private readonly FreelanceJobContext _freelanceJobContext;
        private readonly JwtOptions _jwtOptions;

        /// <summary>
        /// Contructor
        /// </summary>
        public LoginService(FreelanceJobContext freelanceJobContext, IOptions<JwtOptions> jwtOptions)
        {
            _freelanceJobContext = freelanceJobContext ?? throw new ArgumentNullException(nameof(freelanceJobContext)); ;
            _jwtOptions = jwtOptions?.Value ?? throw new ArgumentNullException(nameof(jwtOptions));

        }

        /// <summary>
        /// Login account
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public async Task<string> HandleLoginAccount(LoginRequest request)
        {
            if(request.Username is null)
            {
                throw new InvalidLoginException(InvalidLoginReason.InvalidUsername);
            }

            if (request.Password is null)
            {
                throw new InvalidLoginException(InvalidLoginReason.InvalidPassword);
            }

            var account = await GetAccount(request.Username, request.Password).ConfigureAwait(false);
            
            if(account is null)
            {
                throw new InvalidLoginException(InvalidLoginReason.UserNotExist);
            }

            return JwtBearerHelper.GenerateJSONWebToken(_jwtOptions.Key, _jwtOptions.Issuer, account);

        }

        /// <summary>
        /// Get account
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        private async Task<AccountDto> GetAccount(string username, string password)
        {
            var account = await _freelanceJobContext.TblUsers
                .Where(user => user.Username == username && user.Password == password)
                .Select(user => new AccountDto { 
                    Id = user.Id, 
                    UserName = user.Username,
                    Email = user.Email,
                    FullName = user.Firstname + " " + user.Lastname, 
                    RoleAccount = EnumHelper.GetEnumValue<RoleAccount>(user.Role) })
                .FirstOrDefaultAsync()
                .ConfigureAwait(false);

            if(account is null)
            {
                return null;
            }

            return account;
        }
    }
}
