using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AttributeRouting.Web.Mvc;

namespace GdpSite.Web.Controllers
{
    public class PagesController : Controller
    {
        [GET("/page/{page}")]
        public ActionResult Page(string page)
        {
            return View(page);
        }
    }
}
