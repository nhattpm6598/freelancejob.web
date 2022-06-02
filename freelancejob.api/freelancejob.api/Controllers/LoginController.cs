using freelancejob.business.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace freelancejob.api.Controllers
{
    [ApiController, Route("[controller]")]
    public class LoginController : Controller
    {
        private readonly IUserService _userService;

        /// <summary>
        /// Contructor
        /// </summary>
        /// <param name="userService"></param>
        public LoginController(IUserService userService)
        {
            _userService = userService;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Index(string username, string password)
        {
           var data = await _userService.LoginAccount(username, password).ConfigureAwait(false);

            return Ok(data);
        }
    }
}
