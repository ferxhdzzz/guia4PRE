
// personas

Console.ForegroundColor = ConsoleColor.Black;
 Console.BackgroundColor = ConsoleColor.White;
 Console.Clear();
 Console.Title = " El sexo de una persona ";
 // Declaracion de variables
 int edad;
 String nombre, sexo;
 // Entrada de datos
 Console.WriteLine("\n");
 Console.Write("\tDigitar tu nombre........................: ");
 nombre = Console.ReadLine();
 Console.Write("\tDigitar tu edad..........................: ");
 edad = int.Parse(Console.ReadLine());
 Console.Write("\tDigitar tu sexo ( Hombre=M y Mujer=F )...: ");
 sexo = Console.ReadLine();
 // Procesos
 Console.WriteLine("\n\n");
 if (sexo == "M" || sexo == "m") // instruccion lógica OR
     {
     Console.ForegroundColor = ConsoleColor.DarkCyan;
     Console.WriteLine("\tEl Sr {0} ha sido registrado", nombre); // m
     Console.ForegroundColor = ConsoleColor.Black;
     }
 else
    
 {
     Console.ForegroundColor = ConsoleColor.DarkMagenta;
     Console.WriteLine("\tLa Sra {0} ha sido registrada", nombre); // f
     Console.ForegroundColor = ConsoleColor.Black;
     }
 Console.WriteLine("\n\n");
 //Pantalla opcional
 Console.Write("\t");
 Console.ForegroundColor = ConsoleColor.White;
 Console.BackgroundColor = ConsoleColor.Magenta;
 Console.WriteLine("*********************************************");
 Console.ForegroundColor = ConsoleColor.Black;
 Console.BackgroundColor = ConsoleColor.White;
 Console.WriteLine("\t* *");
 Console.WriteLine("\t* Este programa fue diseñado por: *");
 Console.WriteLine("\t* *");
 Console.WriteLine("\t* fer*");
 Console.WriteLine("\t* *");
 Console.Write("\t");
 Console.ForegroundColor = ConsoleColor.White;
 Console.WriteLine("*********************************************");
 Console.ForegroundColor = ConsoleColor.Black;
 Console.BackgroundColor = ConsoleColor.White;
 Console.Write("\t");
 Console.WriteLine("--> Fin del Programa");
 Console.Write("\t");
 Console.ReadKey();