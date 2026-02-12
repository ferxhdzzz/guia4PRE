Console.ForegroundColor = ConsoleColor.Black;
 Console.BackgroundColor = ConsoleColor.White;
 Console.Clear();
 // Titulo
 Console.Title = ("Ingresamos 3 numeros y obtenemos 4 resultados");
 // Declaración de variables
 int n1, n2, n3, mayor, menor;
 Double suma, promedio;


 // Entrada
 Console.WriteLine("\n");
 Console.Write("\tDigitar el primer numero... : ");
 n1 = int.Parse(Console.ReadLine());
 Console.Write("\tDigitar el segundo numero.. : ");
 n2 = int.Parse(Console.ReadLine());
 Console.Write("\tDigitar el tercer numero... : ");
 n3 = int.Parse(Console.ReadLine());
 // Procesos
 suma = n1 + n2 + n3;
 promedio = (suma / 3);
 Console.Write("\n");
 Console.WriteLine("\t->Imprimiendo resultados<--");
Console.WriteLine("\n");
Console.WriteLine("\t1. La suma de los numeros es : " + suma);
 Console.WriteLine("\t2. El promedio es : " + Math.Round(promedio, 2));
 if (n1 > n2)
     {
     mayor = n1;
     n1 = n2;
     n2 = mayor;
     }
 if (n1 > n3)
     {
     mayor = n1;
     n1 = n3;
     n3 = mayor;
     }
 if (n2 > n3)
     {
     mayor = n2;
     n2 = n3;
     n3 = mayor;
     }
 mayor = n3;
 menor = n1;
 Console.WriteLine("\t3. El mayor de los tres es : " + mayor);
 Console.WriteLine("\t4. El menor de los tres es : " + menor);
 Console.WriteLine("\n\n");
 Console.ReadKey();
