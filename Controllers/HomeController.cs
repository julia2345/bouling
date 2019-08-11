using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RoleHSETemp1.Models;

namespace RoleHSETemp1.Controllers
{
    public class HomeController : Controller
    {
        //RoleGameContext db = new RoleGameContext();
        public ActionResult Index()
        {
            
            //db.games.Add(new RoleGame("dfd", DateTime.Now, 3,3, "ddd", "aaa",true));
            //db.SaveChanges();
            return View();
        }

        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}
    }
}