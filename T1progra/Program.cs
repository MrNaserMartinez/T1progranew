using System;

Console.WriteLine("Bievenido al primer programa con muchos datos\n\n");

Console.WriteLine("Cuarta serie\n 4. Uso de tipos de datos numericos \n ");

Console.WriteLine("*Cacular el area del triangulo ");
Console.WriteLine("Ingrese la base:");
double baset = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ingrese la altura del triángulo:");
double altura = Convert.ToDouble(Console.ReadLine());
double areaTriangulo = (baset * altura)/2;
Console.WriteLine($"El área del triángulo es: {areaTriangulo}\n ");

Console.WriteLine("*Cacular el volumen de una esfera");
Console.WriteLine("Ingrese el radio de la esfera:");
double radio = Convert.ToDouble(Console.ReadLine());
double pi2 = 3.1416;
double volumen = ((4.0/3.0)*pi2)*(radio*radio*radio);
Console.WriteLine($"El volumen de la esfera es: {volumen}");

Console.WriteLine("*Cacular el volumen de una esfera");