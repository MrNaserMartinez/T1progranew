
Console.WriteLine("Bievenido al primer programa con muchos datos feliz feliz\n\n");

Console.WriteLine("Primera series\n 1. Conversión de tipo\n \n ");

Console.WriteLine("*Conversión de número entero a decimal:");
int numeroEntero = 10;
decimal numeroDecimal = Convert.ToDecimal(numeroEntero);
Console.WriteLine($"El número entero {numeroEntero} convertido a decimal es: {numeroDecimal}");

Console.WriteLine("\n*Conversión de número decimal a flotante:");
decimal numeroDecimal2 = 10.5m;
float numeroFlotante = Convert.ToSingle(numeroDecimal2);
Console.WriteLine($"El número decimal {numeroDecimal2} convertido a flotante es: {numeroFlotante}");
