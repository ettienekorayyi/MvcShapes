using MvcShapes.Common;
using MvcShapes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcShapes.Controllers
{
    public class SquareController : Controller
    {
        // GET: Square
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GetAreaOfSquare(int length)
        {
            Shape square = new Shape()
            {
                Name = "Square",
                Area = Utility.ComputeAreaByLength(length)
            };

            return View(square);
        }
    }
}