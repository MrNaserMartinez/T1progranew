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

Console.WriteLine("*Tu buscador de textos");
Console.WriteLine("Ingrese tu frase favorita:");
string texto = Console.ReadLine();
Console.WriteLine("Ingrese la palabra que desea buscar:");
string palabraABuscar = Console.ReadLine();
bool palabraEncontrada = texto.Contains(palabraABuscar);
if (palabraEncontrada)
{
    Console.WriteLine($"La palabra '{palabraABuscar}' fue encontrada en el texto.\n");
}
else
{
    Console.WriteLine($"La palabra '{palabraABuscar}' no fue encontrada en el texto.\n");
}

Console.WriteLine("*Cuantas vocales hay?");
Console.WriteLine("Pon tu palabra");
string palabra = Console.ReadLine().ToLower();
int contador = 0;

for (int i = 0; i < palabra.Length; i++)
{
    if (palabra[i] == 'a' || palabra[i] == 'e' || palabra[i] == 'i' || palabra[i] == 'o' || palabra[i] == 'u')
    {
        contador++;
    }
}
Console.WriteLine("Las vocales son: " + contador);