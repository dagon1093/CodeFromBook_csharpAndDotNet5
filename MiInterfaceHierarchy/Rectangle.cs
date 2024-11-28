using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiInterfaceHierarchy
{
    internal class Rectangle : IShape
    {
        public int GetNumberOfSides() => 4;
         void IPrintable.Draw() => Console.WriteLine("Drawing...");
         void IDrawable.Draw() => Console.WriteLine("Drawing...");
        public void Print() => Console.WriteLine("Printing...");
    }
}
