using Microsoft.AspNetCore.Mvc;
using PedroSerapio.Models;
using System.Diagnostics;

namespace PedroSerapio.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            HomeModel home = new HomeModel();

            home.Nome = "Pedro";
            home.Email = "pedro@teste.pt";

            return View(home);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

    public class DownloadController : Controller
    {
        public IActionResult DownloadCV()
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Downloads/PedroSerápio_en.pdf");

            return PhysicalFile(filePath, "application/pdf", "PedroSerápio_en.pdf");
        }
    }
}