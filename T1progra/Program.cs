using System;

Console.WriteLine("Bievenido al primer programa con muchos datos\n\n");

Console.WriteLine("Segundo serie\n 2. Operaciones con tipos de datos\n ");

Console.WriteLine("*Suma de dos números enteros\n");
Console.WriteLine("Ingrese el primer número entero:");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese el segundo número entero:");
int n2 = Convert.ToInt32(Console.ReadLine());
int suma = n1 + n2;
Console.WriteLine($"La suma de {n1} y {n2} es: {suma}\n");

Console.WriteLine("*Resta de dos número decimales\n");
Console.WriteLine("Ingrese el primer número decimal:");
decimal n3 = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Ingrese el segundo número decimal:");
decimal n4 = Convert.ToDecimal(Console.ReadLine());
decimal resta = n3 - n4;
Console.WriteLine($"La resta de {n3} y {n4} es: {resta}\n");

Console.WriteLine("*Multiplicación de dos número decimales\n");
Console.WriteLine("Ingrese el primer número flotante:");
float n5 = Convert.ToSingle(Console.ReadLine());
Console.WriteLine("Ingrese el segundo número flotante:");
float n6 = Convert.ToSingle(Console.ReadLine());
float multi = n5 * n6;
Console.WriteLine($"La Multiplicación de {n5} y {n6} es: {multi}\n");

Console.WriteLine("*Divison de dos número enteros\n");
Console.WriteLine("Ingrese el primer número entero:");
int n7 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese el segundo número entero:");
float n8 = Convert.ToInt32(Console.ReadLine());
float divi = n7 / n8;
Console.WriteLine($"La Division de {n7} y {n8} es: {divi}\n");

Console.WriteLine("*Modulo de dos número enteros\n");
Console.WriteLine("Ingrese el primer número entero:");
int n9 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese el segundo número entero:");
float n10 = Convert.ToInt32(Console.ReadLine());
float modulo = n7 % n8;
Console.WriteLine($"La Division de {n9} y {n10} es: {modulo}\n");

