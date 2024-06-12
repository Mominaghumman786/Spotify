using Microsoft.AspNetCore.Mvc;

namespace Spotify.Controllers
{
    public class loginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
