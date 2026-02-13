Console.ForegroundColor = ConsoleColor.Black;
Console.BackgroundColor = ConsoleColor.White;
Console.Clear();

// Titulo
Console.WriteLine("\n Ejemplo 8 ");
Console.WriteLine("\n");
Console.Title = ("Determinar tipo de angulo");

// Declaración de variables
double angulo;

Console.WriteLine("\n");

// Entrada
Console.Write("\tDigitar la cantidad de grados.. : ");
angulo = double.Parse(Console.ReadLine());

// Procesos
Console.WriteLine("\n");

if (angulo < 0)
{
    Console.WriteLine("\tEl valor ingresado no es un angulo valido");
}
else if (angulo < 90)
{
    Console.WriteLine("\tEs un angulo Agudo");
}
else if (angulo == 90)
{
    Console.WriteLine("\tEs un angulo Recto");
}
else if (angulo > 90 && angulo < 180)
{
    Console.WriteLine("\tEs un angulo Obtuso");
}
else if (angulo == 180)
{
    Console.WriteLine("\tEs un angulo Llano");
}
else
{
    Console.WriteLine("\tEl valor ingresado no corresponde a un angulo basico");
}

Console.WriteLine("\n\n");
Console.ReadKey();
