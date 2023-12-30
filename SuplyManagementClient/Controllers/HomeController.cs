using Microsoft.AspNetCore.Mvc;
using SuplyManagementClient.Models;
using System.Diagnostics;

namespace SuplyManagementClient.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
    }
}