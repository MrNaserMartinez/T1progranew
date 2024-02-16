using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

Console.WriteLine("*Cacular distancia entre dos puntos");
Console.WriteLine("Ingrese punto X 1:");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ingrese punto Y 1:");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ingrese punto X 2:");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ingrese punto Y 2:");
double y2 = Convert.ToDouble(Console.ReadLine());
double p1 = (x2 - x1);
double p2 = (y2 - y1);
double fin1 = p1 * p1;
double fin2 = p2 * p2;
double final = fin1 + fin2;
double raiz = Math.Sqrt(final);
Console.WriteLine($"El resultado es: {raiz}\n ");

Console.WriteLine("*De celsius a Fahrenheit");
Console.WriteLine("Ingrese los grados celsius:");
double g1 = Convert.ToDouble(Console.ReadLine());
double resul= (g1 * 9 / 5) + 32; ;
Console.WriteLine($"El resultado a Fahrenheit es: {resul}\n ");