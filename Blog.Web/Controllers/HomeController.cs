using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SqlSugar.MySqlConnector;
using Blog.Data.Service;
using Blog.Data.Entity;
using Unity;

namespace Blog.Web.Controllers
{
    public class HomeController : Controller
    {
       [Dependency]
       public IArticeService articleService;
        public ActionResult Index()
        {
            ViewBag.name = articleService.GetTest();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Archive()
        {
            return View();
        }
    }
}