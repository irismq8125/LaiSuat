using Microsoft.AspNetCore.Mvc;

namespace LaiSuat.Controllers
{
    public class LaiSuatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string sotien = "10,000", double laisuat = 6, uint kyhan = 12, int solangui = 2)
        {
            //truyền dữ liệu theo đối tượng
            //LaiSuat ls = new LaiSuat();
            //ls.SoTienGui = sotien.ToString("N0");
            //ls.LaiSuatGui = laisuat.ToString();
            //ls.KyHan = kyhan.ToString();
            //ls.SoTienLai = tienlai.ToString("N0");
            //ls.TongSoTien = (sotien + tienlai).ToString("N0");
            //return View(ls);
            string sotien_string = sotien.Replace(",", ""); // loại bỏ ký tự phân cách
            Int64 sotien_number = Int64.Parse(sotien_string);
            ViewData["SoTien"] = sotien;
            ViewData["LaiSuat"] = laisuat;
            ViewData["KyHan"] = kyhan;
            ViewData["SoLanGui"] = solangui;
            double tienlai = sotien_number * kyhan * laisuat / 1200;
            double tongtien = sotien_number + tienlai;
            ViewData["SoTienLai"] = tienlai.ToString("N0");
            ViewData["TongSoTien"] = tongtien.ToString("N0");
            return View();
        }
    }
}
