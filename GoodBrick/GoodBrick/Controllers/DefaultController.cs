using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoodBrick.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index() => View();
        public ActionResult AboutUs() => View();
        public ActionResult ContactUs() => View();
        public ActionResult Gallery() => View();
        public ActionResult What_are_stabilizedmud_bricks() => View();
        public ActionResult Products() => View();
        public ActionResult Careers() => View();
        public ActionResult Consultation() => View();
    }
}