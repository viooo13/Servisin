using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Servisin.Web.Controllers
{
    [Authorize(Roles = "Admin,Technician")]
    public class AdminController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult Kanban()
        {
            return View();
        }

        public IActionResult Inventory()
        {
            return View();
        }

        public IActionResult Settings()
        {
            return View();
        }
    }
}
