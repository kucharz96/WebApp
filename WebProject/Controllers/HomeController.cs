using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebProject.Code.Authorization;

namespace WebProject.Controllers
{
    public class HomeController : Controller
    {
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }

        [CustomAuthorize("Admin")]
        public ActionResult ForUser()
        {
            return View();
        }
    }
}