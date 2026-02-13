Console.ForegroundColor = ConsoleColor.Black;
Console.BackgroundColor = ConsoleColor.White;
Console.Clear();

// Titulo
Console.WriteLine("\n Ejercicio 4 ");
Console.WriteLine("\n");
Console.Title = ("Tipo de triangulo segun sus lados");

// Declaración de variables
double a, b, c;
double mayor;

Console.WriteLine("\n");

// Entrada
Console.Write("\tDigitar el primer lado.. : ");
a = double.Parse(Console.ReadLine());

Console.Write("\tDigitar el segundo lado.. : ");
b = double.Parse(Console.ReadLine());

Console.Write("\tDigitar el tercer lado.. : ");
c = double.Parse(Console.ReadLine());

// Procesos
Console.WriteLine("\n");

// Determinar el lado mayor
mayor = a;

if (b > mayor)
{
    mayor = b;
}
if (c > mayor)
{
    mayor = c;
}

// Verificar si forman triangulo
if (mayor < (a + b + c - mayor))
{
    Console.WriteLine("\tSi forman un triangulo");

    // Determinar tipo
    if ((a == b) && (b == c))
    {
        Console.WriteLine("\tEs un triangulo Equilatero");
    }
    else if ((a == b) || (a == c) || (b == c))
    {
        Console.WriteLine("\tEs un triangulo Isosceles");
    }
    else
    {
        Console.WriteLine("\tEs un triangulo Escaleno");
    }
}
else
{
    Console.WriteLine("\tNo forman un triangulo");
}

Console.WriteLine("\n\n");
Console.ReadKey();
