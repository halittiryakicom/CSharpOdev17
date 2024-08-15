using CSharpOdev17;


//nesne üretiyoruz.
Console.WriteLine("<---------- KARE ---------->");
BaseGeometricShape kare = new Square();
kare.width = 20;
kare.height = 20;
kare.CalculateArea();

Console.WriteLine("<---------- DİKDÖRTGEN ---------->");
BaseGeometricShape dikdortgen = new Rectangle();
dikdortgen.width = 20;
dikdortgen.height = 30;
dikdortgen.CalculateArea();

Console.WriteLine("<---------- DİK ÜÇGEN ---------->");
BaseGeometricShape ucgen = new Triangle();
ucgen.width = 20;
ucgen.height = 40;
ucgen.CalculateArea();