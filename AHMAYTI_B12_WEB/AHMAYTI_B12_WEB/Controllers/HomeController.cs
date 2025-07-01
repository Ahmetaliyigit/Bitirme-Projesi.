using System.Diagnostics;
using AHMAYTI_B12_WEB.Models;
using BLL;
using Microsoft.AspNetCore.Mvc;

namespace AHMAYTI_B12_WEB.Controllers
{
    public class HomeController : Controller
    {
 
        public async Task<IActionResult> Index()
        {
            return View();
        }

        public async Task<IActionResult> Shop(int Id)
        {
            return View(Id);
        }
    }
}
