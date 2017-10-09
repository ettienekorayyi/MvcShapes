using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcShapes.Common
{
    public class Utility
    {
        public static double ComputeAreaByRadius(double radius)
        {
            return Math.Pow(radius, 2);
        }
        public static double ComputeAreaByLength(double length)
        {
            return Math.Pow(length, 2);
        }
        public static double ComputeAreaByWidthAndHeight(int width,int height)
        {
            return width*height;
        }
    }
}