using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOdev17
{
    internal class Rectangle:BaseGeometricShape
    {
        //baseclassda ki metotu ezerek ekleme yapıyoruz
        public override void CalculateArea()
        {
            Console.WriteLine($"Dikdörtgenin alanı hesaplamasının sonucu");
            base.CalculateArea();
            
        }
    }
}
