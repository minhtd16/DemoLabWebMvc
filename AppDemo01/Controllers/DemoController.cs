using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppDemo01.Controllers
{
    public class DemoController : Controller
    {
        public string Vidu01()
        {
            return "Học lập trình web MVC";
        }
        public int Vidu02()
        {
            int a = 20, b = 30;
            int Tong = a + b;
            return Tong;
        }
        public ActionResult Vidu03()
        {
            string str = "Học lập trình web MVC";
            ViewBag.str = str;
            return View();
        }
        public ActionResult Vidu04()
        {
            string str = "Học lập trình web MVC";
            ViewData["str"] = str;
            return View();            
        }

        public ActionResult Vidu05()
        {
            string tieuDe = "Cách viết mã nguồn C# trên tệp .cshtml";
            ViewBag.tieuDe = tieuDe;
            return View();
        }
    }
}

























































