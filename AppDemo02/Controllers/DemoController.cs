using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppDemo02.Controllers
{
    public class DemoController : Controller
    {       
        public ActionResult Vidu01()
        { 
            /*Chú thích trong C# */
            ViewBag.Title = "Các điều khiển cơ bản trong .cshtml";
            return View();
        }
        public ActionResult Vidu02()
        {
            /*Chú thích trong C# */
            ViewBag.Title = "Cách nhúng mã nguồn C# trên cshtml";
            ViewBag.Content = "Dùng vòng lặp for để tạo table";
            return View();
        }
        public ActionResult Vidu03()
        {
            /*Chú thích trong C# */
            ViewBag.Title = "Cách nhúng mã nguồn C# trên cshtml";
            ViewBag.Content = "Dùng vòng lặp for để tạo table";
            return View();
        }
        public ActionResult Vidu04()
        {
            /*Chú thích trong C# */
            ViewBag.Title = "Cách nhúng mã nguồn C# trên cshtml";
            ViewBag.Content = "Dùng vòng lặp for để tạo table";
            return View();
        }
        public ActionResult Vidu05()
        {
            string[] ListHoTen = { "Lê Hoàng", "Trịnh Tráng", "Quang Cảnh", "Hồng Quân" };
            ViewData["ListHoTen"] = ListHoTen;
            return View();            
        }        
        public ActionResult Vidu06()
        {
            /*Chuyển trang trong MVC */
            ViewBag.Title = "Chuyển trang trong MVC";             
            return View();
        }
        public ActionResult ChuyenTrang()
        {                 
            return RedirectToAction("Vidu05");
        }
        // truyền dữ liệu từ View đến controller:
        public ActionResult Login()
        {            
            return View();
        }
        [HttpPost, ActionName("Login")]
        public ActionResult DangNhapHeThong(string TenDangNhap, string MatKhau)
        {          
            if(TenDangNhap.ToUpper() =="DHCNTTK25A" && MatKhau.ToUpper() == "DHCNTTK25A")
            {
                return RedirectToAction("Vidu05");
            }
            ViewBag.Ten = TenDangNhap;
            ViewBag.Pas = MatKhau;
            ViewBag.Erorr = "Vui lòng nhập đúng tên đăng nhập và mật khẩu";
            return View();
        }
    }
}





