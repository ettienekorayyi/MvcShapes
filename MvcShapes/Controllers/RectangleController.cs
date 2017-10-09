using MvcShapes.Common;
using MvcShapes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcShapes.Controllers
{
    public class RectangleController : Controller
    {
        // GET: Rectangle
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GetAreaOfRectangle(int width, int height)
        {
            Shape rectangle = new Shape()
            {
                Name = "Rectangle",
                Area = Utility.ComputeAreaByWidthAndHeight(width, height)
            };

            return View(rectangle);
        }
    }
}