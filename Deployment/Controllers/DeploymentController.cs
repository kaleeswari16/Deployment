using Microsoft.AspNetCore.Mvc;

namespace Deployment.Controllers
{
    public class DeploymentController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult LoginPage()
        {
            return View();
        }
    }
}
