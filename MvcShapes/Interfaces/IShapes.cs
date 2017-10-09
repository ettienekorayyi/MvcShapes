using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcShapes.Interfaces
{
    public interface IShapes
    {
        double Area { get; set; }
        string Name { get; set; }
    }
}
