Console.ForegroundColor = ConsoleColor.Black;
Console.BackgroundColor = ConsoleColor.White;
Console.Clear();

// Titulo
Console.WriteLine("\n ejercicio 5 ");
Console.WriteLine("\n");
Console.Title = ("Determinar el cuadrante de un punto");

// Declaración de variables
double x, y;

Console.WriteLine("\n");

// Entrada
Console.Write("\tDigitar la coordenada en X.. : ");
x = double.Parse(Console.ReadLine());

Console.Write("\tDigitar la coordenada en Y.. : ");
y = double.Parse(Console.ReadLine());

// Procesos
Console.WriteLine("\n");

if ((x == 0) && (y == 0))
{
    Console.WriteLine("\tEl punto se encuentra en el origen (0,0)");
}
else if ((x > 0) && (y > 0))
{
    Console.WriteLine("\tEl punto pertenece al Cuadrante I");
}
else if ((x < 0) && (y > 0))
{
    Console.WriteLine("\tEl punto pertenece al Cuadrante II");
}
else if ((x < 0) && (y < 0))
{
    Console.WriteLine("\tEl punto pertenece al Cuadrante III");
}
else if ((x > 0) && (y < 0))
{
    Console.WriteLine("\tEl punto pertenece al Cuadrante IV");
}
else if ((x == 0) && (y != 0))
{
    Console.WriteLine("\tEl punto se encuentra sobre el eje Y");
}
else if ((y == 0) && (x != 0))
{
    Console.WriteLine("\tEl punto se encuentra sobre el eje X");
}

Console.WriteLine("\n\n");
Console.ReadKey();
