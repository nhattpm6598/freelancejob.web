using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace freelancejob.api.Controllers
{
    [ApiController, Route("[controller]")]
    public class CategoryController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

    }
}
