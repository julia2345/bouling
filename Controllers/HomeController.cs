using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.Entity;
using RoleHSETemp1.Models;

namespace RoleHSETemp1.Controllers
{
    public class HomeController : Controller
    {
        RoleGameContext db = new RoleGameContext();
        public ActionResult Index()
        {

            //db.games.Add(new RoleGame("dfd", DateTime.Now, 3,3, "ddd", "aaa",true));
            //db.SaveChanges();
            return View();
        }

        public ActionResult HR()
        {
            ViewBag.Message = "HR Edit2";
            //UserContext userdb = new UserContext();
            //userdb.users.Add(new User("Гольмакова", 0, "Здесь должны быть должность. Строку видят все", "Какие то внутренние заметки оргов, эту строку видят только в этом редакторе", "ссылка на вк", "email", true));
            ////userdb.users.Add(new User("Гольмакова1", 0, "Здесь должны быть должность. Строку видят все", "Какие то внутренние заметки оргов, эту строку видят только в этом редакторе", "ссылка на вк", "email", true));
            ////userdb.users.Add(new User("Гольмакова2", 0, "Здесь должны быть должность. Строку видят все", "Какие то внутренние заметки оргов, эту строку видят только в этом редакторе", "ссылка на вк", "email", true));
            //userdb.SaveChanges();
            return View();
        }

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}

        public JsonResult GetTableManagers()
        {
            JsonResult res = null;
            UserContext userDB = new UserContext();
            res = Json(userDB.users.Where(m=>m.IsDeleted==false).Select(m => new { m.nickName, m.position, m.notes, m.vk, m.email, m.accessLevel, m.isActive }).ToList(), JsonRequestBehavior.AllowGet);
            return res;
        }


        public ActionResult addUser(string nick, string position, string email, string vk, string notes, string accessLevel, string isActive)
        {
            string rez = $"Пользователь {nick} добавлен!";
            if (vk.Contains("/"))
            {
                string[] temp = vk.Split('/');
                vk = temp[temp.Length - 1];
            }

            int accLevel = 0;
            if (accessLevel == "Administrator") accLevel = 2;
            if (accessLevel == "Morderator") accLevel = 1;

            bool _isActive = false;
            if (isActive == "True") _isActive = true;

            User tempu = new User(nick, accLevel, position, notes, vk, email, _isActive);
            UserContext userDB = new UserContext();
            if (userDB.users.Where(m => m.IsDeleted == false).Any(t => t.nickName == nick || t.vk == vk || t.email == email))
            {
                rez = "Один из параметров(ник/почта/вк) уже присвоен и не является уникальным. Измените входные данные.";
            }
            else
            {
                userDB.users.Add(tempu);
                userDB.SaveChanges();
            }
            return Json(rez, JsonRequestBehavior.AllowGet);
        }



        public ActionResult deleteUser(string nick)
        {
            string rez = $"Пользователь {nick} удален!";
           

            UserContext userDB = new UserContext();
            try
            {
                var user = userDB.users.Where(m => m.nickName == nick).Where(m => m.IsDeleted == false).FirstOrDefault();
                user.IsDeleted = true;
                userDB.SaveChanges();
            }
            catch
            {
                rez = "Такого пользователя с ником не существует";
            }
            return Json(rez, JsonRequestBehavior.AllowGet);
        }

    }
}