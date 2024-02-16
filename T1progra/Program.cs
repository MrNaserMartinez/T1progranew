Console.WriteLine("Bievenido al primer programa con muchos datos\n\n");

Console.WriteLine("Segundo serie\n 2. Operaciones con tipos de datos\n ");

Console.WriteLine("Conversión de dos números enteros\n");
Console.WriteLine("Ingrese el primer número entero:");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese el segundo número entero:");
int n2 = Convert.ToInt32(Console.ReadLine());
int suma = n1 + n2;
Console.WriteLine($"La suma de {n1} y {n2} es: {suma}");