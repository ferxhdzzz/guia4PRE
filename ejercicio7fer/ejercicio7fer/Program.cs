Console.ForegroundColor = ConsoleColor.Black;
Console.BackgroundColor = ConsoleColor.White;
Console.Clear();

// Titulo
Console.WriteLine("\n Ejercicio 7 ");
Console.WriteLine("\n");
Console.Title = ("Calcular total a pagar en una llanteria");

// Declaración de variables
int cantidad;
double precio, total;

Console.WriteLine("\n");

// Entrada
Console.Write("\tDigitar la cantidad de llantas.. : ");
cantidad = int.Parse(Console.ReadLine());

// Procesos
Console.WriteLine("\n");

if (cantidad < 5)
{
    precio = 800;
}
else
{
    precio = 700;
}

total = cantidad * precio;

// Salida
Console.WriteLine("\tEl precio por llanta es: $" + precio);
Console.WriteLine("\tEl total a pagar es: $" + total);

Console.WriteLine("\n\n");
Console.ReadKey();
