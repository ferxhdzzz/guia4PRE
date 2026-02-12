

Console.ForegroundColor = ConsoleColor.Black;
 Console.BackgroundColor = ConsoleColor.White;
 Console.Clear();
 Console.Title = "Cual es el numero mayor entre 2 numeros";
 Console.Write("\n   Guia#4 Ejemplo1");
 Console.Write("\n\n");
 // Declaracion de variables
 Double x, y;
 // Entrada
 Console.Write("\tAveriguaremos cual es el mayor de 2 numeros...");
 Console.Write("\n\n");
 Console.Write("\tDigitar el primer número : ");
 x = Double.Parse(Console.ReadLine());
 Console.Write("\tDigitar el segundo número : ");
 y = Double.Parse(Console.ReadLine());
 Console.Write("\n");
 //Procesos
 if (x > y)
     {
     Console.WriteLine("\tEl numero " + x + " es mayor que " + y); // v
     }
 else
 

 {
 Console.WriteLine("\tEl numero " + y + " es mayor que " + x); // f
 }
 Console.Write("\n\n");
 //Pantalla opcional
 Console.Write("\t");
 Console.ForegroundColor = ConsoleColor.White;
 Console.BackgroundColor = ConsoleColor.Blue;
 Console.WriteLine("*********************************************");
 Console.ForegroundColor = ConsoleColor.Black;
 Console.BackgroundColor = ConsoleColor.White;
 Console.WriteLine("\t* *");
 Console.WriteLine("\t* Este programa fue diseñado por: *");
 Console.WriteLine("\t* *");
 Console.WriteLine("\t* Fer*");
 Console.WriteLine("\t* *");
 Console.Write("\t");
 Console.ForegroundColor = ConsoleColor.White;
 Console.BackgroundColor = ConsoleColor.Blue;
 Console.WriteLine("*********************************************");
 Console.ForegroundColor = ConsoleColor.Black;
 Console.BackgroundColor = ConsoleColor.White;
 Console.Write("\t");
 Console.WriteLine("--> Fin del Programa");
 Console.Write("\t");
Console.ReadKey();