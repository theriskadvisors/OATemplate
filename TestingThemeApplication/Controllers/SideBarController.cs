using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestingThemeApplication.Controllers
{
    public class SideBarController : Controller
    {
        // GET: SideBar
        public ActionResult Index()
        {
            return PartialView("_AdminLayout");
        }
    }
}