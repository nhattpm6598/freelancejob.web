using freelancejob.api.Models.Responses;
using freelancejob.business.Exceptions;
using freelancejob.business.Models.Requests;
using freelancejob.business.Services.LoginService;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace freelancejob.api.Controllers
{
    [ApiController, Route("[controller]")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class LoginController : Controller
    {
        private readonly ILoginService _loginService;

        /// <summary>
        /// Contructor
        /// </summary>
        /// <param name="loginService"></param>
        public LoginController(ILoginService loginService)
        {
            _loginService = loginService;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [AllowAnonymous, HttpPost("Login")]
        public async Task<IActionResult> LoginAccount([FromBody]LoginRequest request)
        {
            try
            {
                string tokenString = await _loginService.HandleLoginAccount(request).ConfigureAwait(false);

                return CreatedAtAction(nameof(LoginAccount), new BasicResponse() { Code = FreelanceJobContants.CodeSuccess, Data = tokenString });

            }
            catch (InvalidLoginException ex)
            {
                return Problem(ex.ToString(), null, (int)HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return Problem(ex.ToString(), null, (int)HttpStatusCode.InternalServerError);
            }
        }

        [AllowAnonymous,HttpPost("Login/Email")]
        public async Task<IActionResult> LoginFirebase([FromBody] LoginRequest request)
        {
            var accessToken = await HttpContext.GetTokenAsync("access_token");

            return Ok();
        }
    }
}
