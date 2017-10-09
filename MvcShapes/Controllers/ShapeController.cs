using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcShapes.Controllers
{
    public class ShapeController : Controller
    {
        // GET: Shape
        public ActionResult Index()
        {
            return View();
        }
    }
}