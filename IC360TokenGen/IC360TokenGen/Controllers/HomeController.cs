using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;

namespace TokenGenerator.Controllers
{
    public class HomeController : Controller
    {
        //[Authorize]
        public IActionResult Index()
        { 
            return View();
        }


        [Authorize(AuthenticationSchemes = "AAD")]
        public async Task<IActionResult> TokenChallenge()
        {                        
            var id_token = await HttpContext.GetTokenAsync("id_token");
           
            ViewBag.idtoken = id_token;

            return View("Index");
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
