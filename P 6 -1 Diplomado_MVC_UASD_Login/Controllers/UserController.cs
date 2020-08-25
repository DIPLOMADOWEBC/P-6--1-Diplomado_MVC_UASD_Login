using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using P_6__1_Diplomado_MVC_UASD_Login.Models;

namespace P_6__1_Diplomado_MVC_UASD_Login.Controllers
{
    public class UserController : Controller
    {
        SessionData session = new SessionData();
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Users()
        {
            ViewBag.User = session.getSession("userName");
            if (ViewBag.User == "")
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View();

            }
        }

        public ActionResult Close()
        {
            session.destroySession();
            return RedirectToAction("Users", "User");
        }
    }
}