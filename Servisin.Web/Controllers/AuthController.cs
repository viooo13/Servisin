using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Servisin.Web.Controllers
{
    public class AuthController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            if (User.Identity != null && User.Identity.IsAuthenticated)
            {
                return RedirectBasedOnRole(User);
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(string email, string password)
        {
            string role = "Customer"; // Default role

            if (!string.IsNullOrEmpty(email))
            {
                if (email.Contains("superadmin", StringComparison.OrdinalIgnoreCase))
                    role = "SuperAdmin";
                else if (email.Contains("admin", StringComparison.OrdinalIgnoreCase) || email.Contains("tech", StringComparison.OrdinalIgnoreCase))
                    role = "Admin";
            }

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, email ?? "user@servisin.com"),
                new Claim(ClaimTypes.Role, role)
            };

            var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var principal = new ClaimsPrincipal(identity);

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

            return RedirectBasedOnRole(principal);
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(string name, string email, string password, string confirmPassword)
        {
            // For now, redirect to login
            return RedirectToAction("Login");
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login");
        }

        private IActionResult RedirectBasedOnRole(ClaimsPrincipal user)
        {
            if (user.IsInRole("SuperAdmin"))
                return RedirectToAction("Dashboard", "SuperAdmin");
            if (user.IsInRole("Admin") || user.IsInRole("Technician"))
                return RedirectToAction("Dashboard", "Admin");
            
            return RedirectToAction("Dashboard", "Customer");
        }
    }
}
