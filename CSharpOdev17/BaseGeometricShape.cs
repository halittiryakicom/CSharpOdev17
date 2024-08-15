using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOdev17
{
    internal class BaseGeometricShape
    {
        // Baseclass özellikler
        public int width {  get; set; }
        public int height { get; set; }

        // Polymorphism için Virtual Metot
        public virtual void CalculateArea()
        {
            int area = width * height;
            Console.WriteLine(area);
        }
    }
}
