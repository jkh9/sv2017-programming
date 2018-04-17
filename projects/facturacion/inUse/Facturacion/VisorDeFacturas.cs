using System;

class VisorDeFacturas
{
    public ListaDeFacturas Facturas { get; set; }
    public int Index { get; set; }

    public VisorDeFacturas()
    {
        Facturas = new ListaDeFacturas();
        Index = 1;
    }

    public void Ejecutar()
    {
        bool exit = false;
        do
        {
            if (Facturas.Count  >= 1 )
            {
                drawActualFactura();
                getUserImput(ref exit);
            }
            else
            {
                newFactura();
            }
        } while (!exit);
    }

    private void resetConsole()
    {
        Console.Clear();

        Console.SetCursorPosition(0, 0);
        Console.BackgroundColor = ConsoleColor.Blue;
        for (int i = 0; i < Console.WindowHeight; i++)
        {
            Console.Write(new string(' ', Console.WindowWidth + 1));
        }

        Console.SetCursorPosition(0, 0);
        Console.ForegroundColor = ConsoleColor.White;
    }

    private void drawActualFactura()
    {
        resetConsole();

        string line = new string('-', Console.WindowWidth);
        string emptyLine = new string(' ', Console.WindowWidth - 2);
        string helpLine = "1-Anterior  2-Posterior  3-Añadir  4-Añadir Linea  0-Salir";
        string topLine = "Clientes (ficha actual: " + Index + "/" + Facturas.Count + ")";
        string date = (DateTime.Now.Date + "").Substring(0, 11) + "       " +
            (DateTime.Now.Date + "").Substring(11);

        //Cuadrado de arriba
        Console.SetCursorPosition(0, 0);
        Console.Write(line);
        Console.Write("|" + emptyLine + "|");
        Console.Write(line);
        Console.SetCursorPosition(1, 1);
        Console.Write(topLine);
        Console.SetCursorPosition(Console.WindowWidth / 2, 1);
        Console.Write(date);

        //Cabecera factura
        Console.SetCursorPosition(0, 4);
        Console.Write("Número de factura: ");
        Console.Write(Facturas.Get(Index).CabeceraActual.Numero);
        Console.Write("  Fecha: ");
        Console.Write((Facturas.Get(Index).CabeceraActual.Date + "").Substring(0,11));
        Console.Write("  Cliente: ");
        Console.Write(Facturas.Get(Index).CabeceraActual.ClienteActual.Cif);

        //Lineas de factura
        /*for (int i = 0; i < Facturas.Get(Index).Lineas.Count; i++)
        {
            Console.SetCursorPosition(0, 6+i);
            Console.Write(Facturas.Get(Index).Lineas[i].ProductoActual.Codigo);
            Console.Write(" x ");
            Console.Write((Facturas.Get(Index).Lineas[i].Cantidad));
        }*/

        //Parte de abajo
        Console.SetCursorPosition(0, Console.WindowHeight - 4);
        Console.Write(line);
        Console.SetCursorPosition(Console.WindowWidth / 2 -
            (helpLine.Length / 2), Console.WindowHeight - 3);
        Console.WriteLine(helpLine);

        Console.ResetColor();
    }

    private void newFactura()
    {
        Factura facturaToAdd = new Factura();
        ListaDeClientes clientes = new ListaDeClientes();
        resetConsole();

        int cont;
        do
        {
            Console.Write("Código cliente: ");
            string codigo = Console.ReadLine();

            cont = 1;
            do
            {
                if (cont <= clientes.Count && clientes.Get(cont).Cif != codigo)
                {
                    cont++;
                }
            }
            while (cont <= clientes.Count && clientes.Get(cont).Cif != codigo);
            if (cont == clientes.Count + 1)
            {
                Console.WriteLine("Invalid client try again");
            }
            else
            {
                facturaToAdd.CabeceraActual.ClienteActual = clientes.Get(cont);
            }
        } while (facturaToAdd.CabeceraActual.ClienteActual == null);

        facturaToAdd.CabeceraActual.Numero = Facturas.Count + 1;
        facturaToAdd.CabeceraActual.Date = DateTime.Now;

        Facturas.Add(facturaToAdd);
    }

    private void newLinea()
    {
        /*
        LineaDetalle lineaActual = new LineaDetalle();
        ListaDeProductos productos = new ListaDeProductos();
        resetConsole();

        int cont;
        do
        {
            Console.Write("Código producto: ");
            int codigo = Convert.ToInt32(Console.ReadLine());

            cont = 1;
            do
            {
                if (cont <= productos.Count && productos.Get(cont).Codigo != codigo)
                {
                    cont++;
                }
            }
            while (cont <= productos.Count && productos.Get(cont).Codigo != codigo);
            if (cont == productos.Count + 1)
            {
                Console.WriteLine("Invalid product try again");
            }
            else
            {
                lineaActual.ProductoActual = productos.Get(cont);
            }
        } while (lineaActual.ProductoActual == null);

        Console.Write("Cantidad: ");
        try
        {
            lineaActual.Cantidad = Convert.ToInt32(Console.ReadLine());
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid option set 1");
            lineaActual.Cantidad = 1;
        }

        Facturas.Get(Index).Lineas.Add(lineaActual);
        */
    }

    private void getUserImput(ref bool exit)
    {
        ConsoleKeyInfo key;

        do
        {
            key = Console.ReadKey(true);
        } while (Console.KeyAvailable);

        switch (key.Key)
        {
            case ConsoleKey.D0:
                exit = true;
                Facturas.Save();
                break;
            case ConsoleKey.D1:
                if (Index > 1)
                {
                    Index--;
                }
                break;
            case ConsoleKey.D2:
                if (Index < Facturas.Count)
                {
                    Index++;
                }
                break;
            case ConsoleKey.D3:
                newFactura();
                break;
            case ConsoleKey.D4:
                newLinea();
                break;
            default:
                break;
        }
    }
}

