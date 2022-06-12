using freelancejob.business.Models.Dtos;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace freelancejob.business.Helper
{
    public static class JwtBearerHelper
    {
        public static string GenerateJSONWebToken(string key, string issuer, AccountDto account)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var authClaims = new List<Claim>
                {
                    new Claim(JwtRegisteredClaimNames.Jti, account.Id.ToString()),
                    new Claim(JwtRegisteredClaimNames.Sub, account.FullName),
                    new Claim(JwtRegisteredClaimNames.Email, account.Email),
                    new Claim(JwtRegisteredClaimNames.Actort, EnumHelper.DescriptionAttr(account.RoleAccount)),

                };

            var token = new JwtSecurityToken(issuer,
              issuer,
              authClaims,
              expires: DateTime.Now.AddMinutes(720),
              signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
