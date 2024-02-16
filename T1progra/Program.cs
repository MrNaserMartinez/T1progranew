using System;

Console.WriteLine("Bievenido al primer programa con muchos datos\n\n");

Console.WriteLine("Tercera serie\n 3. Uso de Char y String\n ");

Console.WriteLine("*Ingrese una cadena de texto:");
string text = Console.ReadLine();
string Mayus = text.ToUpper();
Console.WriteLine($"La cadena en mayúsculas es: {Mayus}");

Console.WriteLine("*Ingrese una cadena de texto:");
string text1 = Console.ReadLine();
string Minu = text1.ToLower();
Console.WriteLine($"La cadena en mayúsculas es: {Minu}");

