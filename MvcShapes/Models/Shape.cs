using MvcShapes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcShapes.Models
{
    public class Shape : IShapes
    {
        public double Area { get; set; }
        public string Name { get; set; }
    }
}