Console.WriteLine("Bievenido al primer programa con muchos datos\n\n");

Console.WriteLine("Segundo serie\n 2. Operaciones con tipos de datos\n ");

Console.WriteLine("Suma de dos números enteros\n");
Console.WriteLine("Ingrese el primer número entero:");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese el segundo número entero:");
int n2 = Convert.ToInt32(Console.ReadLine());
int suma = n1 + n2;
Console.WriteLine($"La suma de {n1} y {n2} es: {suma}");

Console.WriteLine("Resta de dos número decimales\n");
Console.WriteLine("Ingrese el primer número decimal:");
decimal n3 = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Ingrese el segundo número decimal:");
decimal n4 = Convert.ToInt32(Console.ReadLine());
decimal resta = n3 - n4;
Console.WriteLine($"La suma de {n3} y {n4} es: {resta}");

