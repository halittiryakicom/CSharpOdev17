# PolymorphismExample
Bu projede patika dev .net-core e�itimi i�in C# dili kullanarak Polymorphism �rne�i yap�lm��t�r.

## ��erik
- [Kullan�m](#kullan�m-(usage))
- [Kod A��klamas�](#kod-a��klamas�)

## Kullan�m (Usage)
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

            Console.WriteLine("<---------- D�KD�RTGEN ---------->");
            BaseGeometricShape dikdortgen = new Rectangle();
            dikdortgen.width = 20;
            dikdortgen.height = 30;
            dikdortgen.CalculateArea();

            Console.WriteLine("<---------- D�K ��GEN ---------->");
            BaseGeometricShape ucgen = new Triangle();
            ucgen.width = 20;
            ucgen.height = 40;
            ucgen.CalculateArea();
        }
    }
}

Yukar�daki kod blo�u BaseGeometric s�n�f�ndan referans alm��  ve BaseS�n�ftaki metodu ezerek �zerine eklemeler yaparak alan hesaplamas� yapm��t�r.


## Kod A��klamas�
BaseGeometric Class
width, height: Base Class da prototype
CaculateArea(): Method that prints the person's title, first name, and last name.

Square Class
Inherits from BaseGeometric.
CaculateArea(): Buradaki metod Basedeki metodumuzla overload edilip basedeki metodumuzu ezerek kullan�lm��t�r.

Rectangle Class
Inherits from BaseGeometric.
CaculateArea(): Buradaki metod Basedeki metodumuzla overload edilip basedeki metodumuzu ezerek kullan�lm��t�r.

Triangle Class
Inherits from BaseGeometric.
CaculateArea(): Buradaki metod Basedeki metodumuzla overload edilip basedeki metodumuzu ezerek kullan�lm��t�r.
