using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03_oop.Interface
{
    internal interface IRectangle:IShape
    {
        double Width { get; set; }
        double Height { get; set; }
    }
}
