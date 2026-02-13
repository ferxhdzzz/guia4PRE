Console.ForegroundColor = ConsoleColor.Black;
Console.BackgroundColor = ConsoleColor.White;
Console.Clear();

// Titulo
Console.WriteLine("\n Ejericicio 2 ");
Console.WriteLine("\n");
Console.Title = ("Determinar el numero mayor de tres numeros");

// Declaración de variables
int a, b, c;

Console.WriteLine("\n");

// Entrada
Console.Write("\tDigitar el primer numero.. : ");
a = int.Parse(Console.ReadLine());

Console.Write("\tDigitar el segundo numero.. : ");
b = int.Parse(Console.ReadLine());

Console.Write("\tDigitar el tercer numero.. : ");
c = int.Parse(Console.ReadLine());

// Procesos
Console.WriteLine("\n");


if ((a < b) && (a < c))
{
    Console.WriteLine("\tEl numero menor es: " + a);
}
else if ((b < a) && (b < c))
{
    Console.WriteLine("\tEl numero menor es: " + b);
}
else if ((c < a) && (c < b))
{
    Console.WriteLine("\tEl numero menor es: " + c);
}
else
{
    Console.WriteLine("\tHay numeros iguales y no existe un unico menor");
}

Console.WriteLine("\n\n");
Console.ReadKey();
