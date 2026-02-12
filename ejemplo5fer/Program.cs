Console.ForegroundColor = ConsoleColor.Black;
 Console.BackgroundColor = ConsoleColor.White;
 Console.Clear();
// Titulo
Console.WriteLine("\n ejemplo 5 ");
Console.WriteLine("\n");
Console.Title = ("Cuantas cifras posee un numero entero");
 // Declaración de variables
 int a;
 Console.WriteLine("\n");
 // Entrada
 Console.Write("\tDigitar un numero entero entre [1 - 1000].. : ");
 a = int.Parse(Console.ReadLine());
 // Procesos
 Console.WriteLine("\n");
 if ((a >= 1) && (a <= 1000))
     {
     if ((a >= 1) && (a <= 9))
         {
         Console.WriteLine("\tEl numero " + a + " posee una cifra");
         }
     else if ((a >= 10) && (a <= 99))
         {
         Console.WriteLine("\tEl numero " + a + " posee dos cifras");
         }
     else if ((a >= 100) && (a <= 999))
         {
         Console.WriteLine("\tEl numero " + a + " posee tres cifras");
         }
     else
         {
         Console.WriteLine("\tEl numero " + a + " posee cuatro cifras");
         }
     }
 else
     {
     Console.WriteLine("\tEl numero esta fuera del rango");
     }
 Console.WriteLine("\n\n");
 Console.ReadKey();