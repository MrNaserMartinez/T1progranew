using System;

Console.WriteLine("Bienvenido al sistema del ejercicio 2da semana\n\n");

Console.WriteLine("Primera series\n 1. Conversión de tipo\n \n ");

Console.WriteLine("*Conversión de número entero a decimal:");
Console.WriteLine("Ingresa el número para el proceso\n" );
int n1 = Convert.ToInt32(Console.ReadLine());
decimal n2 = Convert.ToDecimal(n1);
Console.WriteLine($"El número decimal es: {n2}\n");

Console.WriteLine("*Conversión de número decimal a flotante:a");
Console.WriteLine("Ingresa el número para el proceso\n");
decimal n3 = Convert.ToDecimal(Console.ReadLine());
float n4 = Convert.ToSingle(n3);
Console.WriteLine($"El número flotante es: {n4}\n");

Console.WriteLine("*Conversión de número flotante a enteroo:");
Console.WriteLine("Ingresa el número para el proceso\n");
decimal n5 = Convert.ToDecimal(Console.ReadLine());
float n6 = Convert.ToSingle(n5);
Console.WriteLine($"El número flotante es: {n6}\n");

Console.WriteLine("Ingrese un carácter:");
char n7 = Console.ReadKey().KeyChar; 
int n8 = (int)n7;
Console.WriteLine($"\nEl valor entero del carácter '{n7}' es: {n8}");

Console.WriteLine("Ingrese un entero para hacerlo caracter hola");
int n9 = Convert.ToInt32(Console.ReadLine());
char n10 = Convert.ToChar(n9);
Console.WriteLine("El caracter es " + n10);

