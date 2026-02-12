Console.ForegroundColor = ConsoleColor.Black;
 Console.BackgroundColor = ConsoleColor.White;
 Console.Clear();
 Console.Title = ("Programa que calcule las raíces de una ecuación de 2do grado");
 // Declaracion de variables
 Double a, b, c, disc, x1, x2;

Console.WriteLine("\n Ejempplo 2");

// Entrada de datos
Console.WriteLine("\n");
 Console.Write("\tIngresa el coeficiente cuadratico [a]...: ");
 a = Double.Parse(Console.ReadLine());
 Console.Write("\tIngresa el coeficiente lineal [b].......: ");
 b = Double.Parse(Console.ReadLine());
 Console.Write("\tIngresa la constante [c]................: ");
 c = Double.Parse(Console.ReadLine());
 // Procesos
 Console.WriteLine("\n\tLa solución es:");
 disc = (Math.Pow(b, 2) - 4 * a * c);
 if (a != 0)
     {
     if (disc < 0)
         {
         Console.ForegroundColor = ConsoleColor.DarkBlue;
         Console.WriteLine("\tTiene raices imaginarias!!!");
         Console.ForegroundColor = ConsoleColor.Black;
         }
     else
         {
         x1 = (-b + Math.Sqrt(disc)) / (2 * a);
         x2 = (-b - Math.Sqrt(disc)) / (2 * a);
         Console.ForegroundColor = ConsoleColor.Black;
         Console.Write("\tx1 = " + Math.Round(x1, 3));
         Console.ForegroundColor = ConsoleColor.Black;
         Console.ForegroundColor = ConsoleColor.Red;
         Console.Write("\tx2 = " + Math.Round(x2, 3));
         Console.ForegroundColor = ConsoleColor.Black;
         }
     }
 else
     {
     Console.ForegroundColor = ConsoleColor.DarkCyan;
     Console.WriteLine("\tEl coeficiente cuadratico debe ser diferente de 0");
     Console.ForegroundColor = ConsoleColor.Black;
     }
 Console.Write("\n\n");
 //Pantalla opcional
 Console.Write("\t");
 Console.ForegroundColor = ConsoleColor.White;
 Console.BackgroundColor = ConsoleColor.DarkMagenta;
 Console.WriteLine("*********************************************");
 Console.ForegroundColor = ConsoleColor.Black;
 Console.BackgroundColor = ConsoleColor.White;
 Console.WriteLine("\t* *");
 Console.WriteLine("\t* Este programa fue diseñado por: *");
 Console.WriteLine("\t* *");
 Console.WriteLine("\t* fer *");
 Console.WriteLine("\t* *");

 Console.Write("\t");
 Console.ForegroundColor = ConsoleColor.White;
 Console.BackgroundColor = ConsoleColor.DarkMagenta;
 Console.WriteLine("*********************************************");
 Console.ForegroundColor = ConsoleColor.Black;
 Console.BackgroundColor = ConsoleColor.White;
 Console.Write("\t");
 Console.WriteLine("--> Fin del Programa");
 Console.Write("\t");
 Console.ReadKey();