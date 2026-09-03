using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Servisin.Web.Controllers
{
    [Authorize(Roles = "Customer")]
    public class CustomerController : Controller
    {
        public IActionResult Dashboard()
        {
            return Content("Customer Dashboard Placeholder. Coming Soon!");
        }
    }
}
