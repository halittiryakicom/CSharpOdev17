using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOdev17
{
    internal class Triangle:BaseGeometricShape
    {
        //baseclassda ki metotu ezerek hesaplamayı farklı yapıyoruz.
        public override void CalculateArea()
        {
            int area = (width * height)/2;
            Console.WriteLine($"Dik üçgenin alanı: {area}'dır.");
        }
    }
}
