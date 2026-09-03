using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Servisin.Web.Controllers
{
    [Authorize(Roles = "SuperAdmin")]
    public class SuperAdminController : Controller
    {
        public IActionResult Dashboard()
        {
            return Content("SuperAdmin Dashboard Placeholder. Coming Soon!");
        }
    }
}
