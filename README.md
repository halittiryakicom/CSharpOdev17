# PolymorphismExample
Bu projede patika dev .net-core eðitimi için C# dili kullanarak Polymorphism örneði yapýlmýþtýr.

## Ýçerik
- [Kullaným](#kullaným-(usage))
- [Kod Açýklamasý](#kod-açýklamasý)

## Kullaným (Usage)
using System;
namespace InheritanceExample
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<---------- KARE ---------->");
            BaseGeometricShape kare = new Square();
            kare.width = 20;
            kare.height = 20;
            kare.CalculateArea();

            Console.WriteLine("<---------- DÝKDÖRTGEN ---------->");
            BaseGeometricShape dikdortgen = new Rectangle();
            dikdortgen.width = 20;
            dikdortgen.height = 30;
            dikdortgen.CalculateArea();

            Console.WriteLine("<---------- DÝK ÜÇGEN ---------->");
            BaseGeometricShape ucgen = new Triangle();
            ucgen.width = 20;
            ucgen.height = 40;
            ucgen.CalculateArea();
        }
    }
}

Yukarýdaki kod bloðu BaseGeometric sýnýfýndan referans almýþ  ve BaseSýnýftaki metodu ezerek üzerine eklemeler yaparak alan hesaplamasý yapmýþtýr.


## Kod Açýklamasý
BaseGeometric Class
width, height: Base Class da prototype
CaculateArea(): Method that prints the person's title, first name, and last name.

Square Class
Inherits from BaseGeometric.
CaculateArea(): Buradaki metod Basedeki metodumuzla overload edilip basedeki metodumuzu ezerek kullanýlmýþtýr.

Rectangle Class
Inherits from BaseGeometric.
CaculateArea(): Buradaki metod Basedeki metodumuzla overload edilip basedeki metodumuzu ezerek kullanýlmýþtýr.

Triangle Class
Inherits from BaseGeometric.
CaculateArea(): Buradaki metod Basedeki metodumuzla overload edilip basedeki metodumuzu ezerek kullanýlmýþtýr.
