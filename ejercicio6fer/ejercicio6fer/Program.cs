Console.ForegroundColor = ConsoleColor.Black;
Console.BackgroundColor = ConsoleColor.White;
Console.Clear();

// Titulo
Console.WriteLine("\n Ejercicio 6 ");
Console.WriteLine("\n");
Console.Title = ("Calcular total a pagar por compra de camisas");

// Declaración de variables
int cantidad;
double precio, total, descuento, totalPagar;

Console.WriteLine("\n");

// Entrada
Console.Write("\tDigitar la cantidad de camisas.. : ");
cantidad = int.Parse(Console.ReadLine());

Console.Write("\tDigitar el precio por camisa.. : ");
precio = double.Parse(Console.ReadLine());

// Procesos
Console.WriteLine("\n");

total = cantidad * precio;

if (cantidad >= 3)
{
    descuento = total * 0.20;
}
else
{
    descuento = total * 0.10;
}

totalPagar = total - descuento;

// Salida
Console.WriteLine("\tEl total de la compra es: $" + total);
Console.WriteLine("\tEl descuento aplicado es: $" + descuento);
Console.WriteLine("\tEl total a pagar es: $" + totalPagar);

Console.WriteLine("\n\n");
Console.ReadKey();
