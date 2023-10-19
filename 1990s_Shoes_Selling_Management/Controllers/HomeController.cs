using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _1990s_Shoes_Selling_Management.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ShowHomePage()
        {
            return View();
        }
        public ActionResult ShowShoesPage(string id = "Men")
        {
            return View();
        }

        public ActionResult ShowShoesDetail(string id = "Shoes-123")
        {
            return View();
        }
    }
}