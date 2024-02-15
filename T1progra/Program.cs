Console.WriteLine("Bievenido al primer programa con muchos datos\n\n");

Console.WriteLine("Primera series\n 1. Conversión de tipo\n \n ");

Console.WriteLine("*Conversión de número entero a decimal:");
Console.WriteLine("Ingresa el número para el proceso\n" );
int n1 = Convert.ToInt32(Console.ReadLine());
decimal n2 = Convert.ToDecimal(n1);
Console.WriteLine($"El número decimal es: {n2}\n");

Console.WriteLine("*Conversión de número decimal a flotante:");
Console.WriteLine("Ingresa el número para el proceso\n");
decimal n3 = Convert.ToDecimal(Console.ReadLine());
float n4 = Convert.ToSingle(n3);
Console.WriteLine($"El número flotante es: {n4}\n");

Console.WriteLine("*Conversión de número flotante a entero:");
Console.WriteLine("Ingresa el número para el proceso\n");
decimal n5 = Convert.ToDecimal(Console.ReadLine());
float n6 = Convert.ToSingle(n5);
Console.WriteLine($"El número flotante es: {n6}\n");

