using MvcShapes.Common;
using MvcShapes.Interfaces;
using MvcShapes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcShapes.Controllers
{
    public class CircleController : Controller
    {
        // GET: Circle
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GetAreaOfCircle(int radius)
        {
            Shape circle = new Shape() 
            { 
                Name = "Circle",
                Area = Utility.ComputeAreaByRadius(radius)
            };
            
            return View(circle);
        }
    }
}