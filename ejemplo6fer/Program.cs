

Console.ForegroundColor = ConsoleColor.Black;
 Console.BackgroundColor = ConsoleColor.White;
 Console.Clear();
 Console.Title = "Consumo de energia en SoyaCity";
 // Declaracion de variables
 int consumo, tipoCliente;
 Double precioKwh = 0, subtotal, ajuste = 0, impuesto = 0;
 Double total;
 // Entrada
 Console.Write("\n\tIngrese el consumo mensual en kWh: ");
 consumo = int.Parse(Console.ReadLine());
 //Procesos
 Console.WriteLine("\n\t--- Tipo de cliente ---");
 Console.WriteLine("\t 1 - Residencial");
 Console.WriteLine("\t 2 - Comercial");
 Console.WriteLine("\t 3 - Industrial");
 Console.Write("\n\tSeleccione el tipo de cliente: ");
 tipoCliente = int.Parse(Console.ReadLine());
 // Determinar precio por kWh según tipo de cliente y consumo
 if (tipoCliente == 1) // Residencial
     {
     if (consumo <= 100)
         precioKwh = 0.10;
     else if (consumo <= 200)
         precioKwh = 0.12;
     else
         precioKwh = 0.15;
     }
 else if (tipoCliente == 2) // Comercial
     {
     if (consumo <= 200)
        
     precioKwh = 0.15;
     else if (consumo <= 500)
         precioKwh = 0.18;
     else
         precioKwh = 0.20;
     }
 else if (tipoCliente == 3) // Industrial
     {
     if (consumo <= 500)
         precioKwh = 0.20;
     else
         precioKwh = 0.25;
     }
 else
     {
     Console.WriteLine("Tipo de cliente inválido.");
     return;
     }
 subtotal = consumo * precioKwh;

 // Aplicar recargo o descuento
 if (consumo > 400)
     {
     ajuste = subtotal * 0.10; // Recargo 10%
     }
 else if (consumo < 80 && tipoCliente == 1)
     {
     ajuste = subtotal * -0.05; // Descuento 5%
     }
 subtotal = subtotal + ajuste;

 // Calcular impuesto
 if (subtotal > 100)
     {
     impuesto = subtotal * 0.13;
     }
 total = subtotal + impuesto;

 // Mostrar resultados
 Console.WriteLine("\n\t--- FACTURA DE ENERGÍA ---");
 Console.WriteLine("\t Consumo : " + consumo + " kWh");
 Console.WriteLine("\t Precio por kWh : $" + precioKwh);
 Console.WriteLine("\t Subtotal : $" + Math.Round(subtotal - impuesto, 2));
 Console.WriteLine("\t Ajuste aplicado: $" + Math.Round(ajuste, 2));
 Console.WriteLine("\t Impuesto : $" + Math.Round(impuesto, 2));
 Console.WriteLine("\t TOTAL A PAGAR : $" + Math.Round(total, 2));
 //Pantalla opcional
 Console.Write("\n\n\t");
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
 Console.BackgroundColor = ConsoleColor.DarkCyan;
 Console.WriteLine("*********************************************");
 Console.ForegroundColor = ConsoleColor.Black;
 Console.BackgroundColor = ConsoleColor.White;
 Console.Write("\t");
 Console.WriteLine("--> Fin del Programa");
 Console.Write("\t");
 Console.ReadKey();