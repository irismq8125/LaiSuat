using LaiSuat.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LaiSuat.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string sotien, double laisuat, uint kyhan)
        {
            string sotien_string = sotien.Replace(",", ""); // loại bỏ ký tự phân cách
            Int64 sotien_number = Int64.Parse(sotien_string);
            ViewData["sotien"] = sotien;
            ViewData["laisuat"] = laisuat;
            ViewData["kyhan"] = kyhan;
            double tienlai = sotien_number * kyhan * laisuat / 1200;
            double tongtien = sotien_number + tienlai;
            ViewData["tienLai"] = tienlai.ToString("N2");
            ViewData["tongTien"] = tongtien.ToString("N2");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}