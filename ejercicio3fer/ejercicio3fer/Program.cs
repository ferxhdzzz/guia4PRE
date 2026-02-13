Console.ForegroundColor = ConsoleColor.Black;
Console.BackgroundColor = ConsoleColor.White;
Console.Clear();

// Titulo
Console.WriteLine("\n Ejercicio 3 ");
Console.WriteLine("\n");
Console.Title = ("Promedio de practicas eliminando la nota menor");

// Declaración de variables
double n1, n2, n3, n4;
double menor, promedio;

Console.WriteLine("\n");

// Entrada
Console.Write("\tDigitar la primera nota.. : ");
n1 = double.Parse(Console.ReadLine());

Console.Write("\tDigitar la segunda nota.. : ");
n2 = double.Parse(Console.ReadLine());

Console.Write("\tDigitar la tercera nota.. : ");
n3 = double.Parse(Console.ReadLine());

Console.Write("\tDigitar la cuarta nota.. : ");
n4 = double.Parse(Console.ReadLine());

// Procesos
Console.WriteLine("\n");

// Suponemos que la primera es la menor
menor = n1;

if (n2 < menor)
{
    menor = n2;
}
if (n3 < menor)
{
    menor = n3;
}
if (n4 < menor)
{
    menor = n4;
}

// Calculamos el promedio eliminando la menor
promedio = (n1 + n2 + n3 + n4 - menor) / 3;

// Salida
Console.WriteLine("\tLa nota eliminada es: " + menor);
Console.WriteLine("\tEl promedio de practicas es: " + promedio);

Console.WriteLine("\n\n");
Console.ReadKey();
