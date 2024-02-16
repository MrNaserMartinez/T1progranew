using System;

Console.WriteLine("Bievenido al primer programa con muchos datos\n\n");

Console.WriteLine("Tercera serie\n 3. Uso de Char y String\n ");

Console.WriteLine("*Convertir en mayuscula:");
Console.WriteLine("*Ingrese una cadena de texto:");
string text = Console.ReadLine();
string Mayus = text.ToUpper();
Console.WriteLine($"La cadena en mayúsculas es: {Mayus}");

Console.WriteLine("*Convertir en Minuscula:");
Console.WriteLine("*Ingrese una cadena de texto:\n");
string text1 = Console.ReadLine();
string Minu = text1.ToLower();
Console.WriteLine($"La cadena en mayúsculas es: {Minu}\n");

Console.WriteLine("*Tu texto al réves:");
Console.WriteLine("Ingrese una cadena de texto:\n");
string cadena = Console.ReadLine();
string cadenaInvertida = "";
for (int i = cadena.Length - 1; i >= 0; i--)
{
    cadenaInvertida += cadena[i];
}
Console.WriteLine($"La cadena invertida es: {cadenaInvertida}\n");

