 // Facturación, clase "VisorDeClientes"

// Versiones:
// V0.01a 11-Abr-2018 Raúl Gogna: Muestra esqueleto, analiza opciones
// V0.01b 14-Abr-2018 Nacho: Crea un dato prefijado, muestra dato y menú
// V0.03a 14-Abr-2018 Raúl Gogna, correcciones por Nacho: 
//            Ver, anterior, posterior, añadir
// V0.04a 15-Abr-2018 Raúl Gogna, correcciones por Nacho: 
//            Número, buscar, modificar
// V0.07a 17-Abr-2018 Nacho: Renombrado a VisorDeClientes
/* V0.08a 20-Abr-2018 Moisés: Funciones para parte arriba y abajo, 
 * drawActualClient y new client usan Consola Mejorada
*/

using System;
using System.Collections.Generic;

class VisorDeClientes
{
    public ListaDeClientes Clientes { get; set; }
    public int Index { get; set; }

    public VisorDeClientes()
    {
        Clientes = new ListaDeClientes();
        Index = 0;
    }

    public void Ejecutar()
    {
        bool exit = false;
        do
        {
            drawActualClient();
            getUserImput(ref exit);
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

    private void drawTop()
    {
        string line = new string('-', Console.WindowWidth);
        string emptyLine = new string(' ', Console.WindowWidth - 2);
        string topLine = "Clientes (ficha actual: " + (Index+1) + "/" + Clientes.Count + ")";
        string date = (DateTime.Now + "").Substring(0, 11) + "       " +
            (DateTime.Now + "").Substring(11);

        //Cuadrado de arriba
        Console.SetCursorPosition(0, 0);
        Console.Write(line);
        Console.Write("|" + emptyLine + "|");
        Console.Write(line);
        Console.SetCursorPosition(1, 1);
        Console.Write(topLine);
        Console.SetCursorPosition(Console.WindowWidth / 2, 1);
        Console.Write(date);
    }

    private void drawBottom()
    {
        string line = new string('-', Console.WindowWidth);
        string helpLine1 = "1-Anterior  2-Posterior  3-Número  4-Buscar  " +
            "5-Añadir  6-Modificar  B-Borrar";
        string helpLine2 = "7-Listados  F1-Ayuda  0-Terminar";

        //Parte de abajo
        Console.SetCursorPosition(0, Console.WindowHeight - 4);
        Console.Write(line);
        Console.SetCursorPosition(Console.WindowWidth / 2 -
            (helpLine1.Length / 2), Console.WindowHeight - 3);
        Console.WriteLine(helpLine1);
        Console.SetCursorPosition(Console.WindowWidth / 2 -
            (helpLine2.Length / 2), Console.WindowHeight - 2);
        Console.WriteLine(helpLine2);
    }

    private void drawActualClient()
    {
        resetConsole();

        drawTop();

        if (Clientes.Count > 0)
        {
            //Cuerpo del programa
            ConsolaMejorada.Escribir(0, 4, "Nombre: ", "white",false);
            ConsolaMejorada.Escribir(11, 4, 
                checkVacio(Clientes.Get(Index).Nombre), "white",true);

            ConsolaMejorada.Escribir(0, 5, "DNI / CIF: ", "white",false);
            ConsolaMejorada.Escribir(11, 5,
                checkVacio(Clientes.Get(Index).Cif), "white", true);

            ConsolaMejorada.Escribir(0, 7, "Domicilio: ", "white", false);
            ConsolaMejorada.Escribir(11, 7,
                checkVacio(Clientes.Get(Index).Domicilio), "white", true);

            ConsolaMejorada.Escribir(0, 8, "Ciudad: ", "white", false);
            ConsolaMejorada.Escribir(11, 8,
                checkVacio(Clientes.Get(Index).Ciudad), "white", true);

            ConsolaMejorada.Escribir(0, 9, "Cod.Postal: ", "white", false);
            ConsolaMejorada.Escribir(11, 9,
                checkVacio(Clientes.Get(Index).CodigoPostal.ToString("00000")), 
                "white", true);

            ConsolaMejorada.Escribir(0, 10, "Pais: ", "white", false);
            ConsolaMejorada.Escribir(11, 10,
                checkVacio(Clientes.Get(Index).Pais), "white", true);

            ConsolaMejorada.Escribir(0, 11, "Teléfono: ", "white", false);
            ConsolaMejorada.Escribir(11, 11,
                checkVacio(Clientes.Get(Index).Telefono), "white", true);

            ConsolaMejorada.Escribir(0, 12, "E-mail: ", "white", false);
            ConsolaMejorada.Escribir(11, 12,
                checkVacio(Clientes.Get(Index).Email), "white", true);

            ConsolaMejorada.Escribir(0, 13, "Contacto: ", "white", false);
            ConsolaMejorada.Escribir(11, 13,
                checkVacio(Clientes.Get(Index).Contacto), "white", true);

            ConsolaMejorada.Escribir(0, 15, "Observaciones: ", "white", false);
            ConsolaMejorada.Escribir(11, 15,
                checkVacio(Clientes.Get(Index).Observaciones), "white", true);
        }

        drawBottom();
        Console.ResetColor();
    }

    private string checkVacio(string lineToCheck)
    {
        if (lineToCheck == "" || lineToCheck == null)
        {
            return "(Por Confirmar)";
        }
        else
        {
            return lineToCheck.ToString();
        }
    }

    private string checkVacio(int lineToCheck)
    {
        if (lineToCheck == 0)
        {
            return "(Por Confirmar)";
        }
        else
        {
            return lineToCheck.ToString();
        }
    }

    private Cliente newClient()
    {
        resetConsole();

        drawTop();

        Cliente ClientToAdd = new Cliente();

        ConsolaMejorada.Escribir(0, 4, "Nombre: ", "white", false);
        ClientToAdd.Nombre = ConsolaMejorada.Pedir(11, 4,20);

        ConsolaMejorada.Escribir(0, 5, "DNI / CIF: ", "white", false);
        ClientToAdd.Cif = ConsolaMejorada.Pedir(11, 5, 9);

        ConsolaMejorada.Escribir(0, 7, "Domicilio: ", "white", false);
        ClientToAdd.Domicilio = ConsolaMejorada.Pedir(11, 7, 20);

        ConsolaMejorada.Escribir(0, 8, "Ciudad: ", "white", false);
        ClientToAdd.Ciudad = ConsolaMejorada.Pedir(11, 8, 20);

        ConsolaMejorada.Escribir(0, 9, "Cod.Postal: ", "white", false);
        try
        {
            ClientToAdd.CodigoPostal = Convert.ToInt32(ConsolaMejorada.Pedir(11, 9, 5));
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid number");
        }

        ConsolaMejorada.Escribir(0, 10, "Pais: ", "white", false);
        ClientToAdd.Pais = ConsolaMejorada.Pedir(11, 10, 10);

        ConsolaMejorada.Escribir(0, 11, "Teléfono: ", "white", false);
        try
        {
            ClientToAdd.Telefono = Convert.ToInt32(ConsolaMejorada.Pedir(11, 11, 9));
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid number");
        }

        ConsolaMejorada.Escribir(0, 12, "E-mail: ", "white", false);
        ClientToAdd.Email = ConsolaMejorada.Pedir(11, 12, 40);

        ConsolaMejorada.Escribir(0, 13, "Contacto: ", "white", false);
        ClientToAdd.Contacto = ConsolaMejorada.Pedir(11, 13, 20);

        ConsolaMejorada.Escribir(0, 14, "Observaciones: ", "white", false);
        ClientToAdd.Observaciones = ConsolaMejorada.Pedir(13, 14, 40);

        if (ClientToAdd.Observaciones == "")
            ClientToAdd.Observaciones = "Sin Comentarios";

        drawBottom();

        return ClientToAdd;
    }

    private int JumpIntoClient()
    {
        resetConsole();
        int client = Index;
        Console.Write("Index? ");
        try
        {
            client = Convert.ToInt32(Console.ReadLine());
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid number");
            Console.WriteLine("Press enter to return");
            Console.ReadLine();
        }

        if (client > Clientes.Count)
        {
            client = Index;
            Console.WriteLine("Doesn't exist");
            Console.WriteLine("Press enter to return");
            Console.ReadLine();
        }

        return client;
    }

    private Cliente modifyClient(Cliente actual)
    {
        resetConsole();

        drawTop();

        Cliente ClientToAdd = actual;
        string cadena;

        ConsolaMejorada.Escribir(0, 4, "Press enter to not modify", "white", false);

        Console.Write("Nombre (" + ClientToAdd.Nombre + "): ");
        cadena = Console.ReadLine();
        if (cadena != "")
        {
            ClientToAdd.Nombre = cadena;
        }
        Console.Write("DNI / CIF (" + ClientToAdd.Cif + "): ");
        cadena = Console.ReadLine();
        if (cadena != "")
        {
            ClientToAdd.Cif = cadena;
        }
        Console.Write("Domicilio (" + ClientToAdd.Domicilio + "): ");
        cadena = Console.ReadLine();
        if (cadena != "")
        {
            ClientToAdd.Domicilio = cadena;
        }
        Console.Write("Ciudad (" + ClientToAdd.Ciudad + "): ");
        cadena = Console.ReadLine();
        if (cadena != "")
        {
            ClientToAdd.Ciudad = cadena;
        }

        Console.Write("Cod.Postal (" + ClientToAdd.CodigoPostal + "): ");
        try
        {
            ClientToAdd.CodigoPostal = Convert.ToInt32(Console.ReadLine());
        }
        catch (Exception)
        {
        }

        Console.Write("Pais (" + ClientToAdd.Pais + "): ");
        cadena = Console.ReadLine();
        if (cadena != "")
        {
            ClientToAdd.Pais = cadena;
        }
        Console.Write("Teléfono (" + ClientToAdd.Telefono + "): ");
        try
        {
            ClientToAdd.Telefono = Convert.ToInt32(Console.ReadLine());
        }
        catch (Exception)
        {
        }

        Console.Write("E-mail (" + ClientToAdd.Email + "): ");
        cadena = Console.ReadLine();
        if (cadena != "")
        {
            ClientToAdd.Email = cadena;
        }
        Console.Write("Contacto (" + ClientToAdd.Contacto + "): ");
        cadena = Console.ReadLine();
        if (cadena != "")
        {
            ClientToAdd.Contacto = cadena;
        }
        Console.Write("Observaciones (" + ClientToAdd.Observaciones + "): ");
        cadena = Console.ReadLine();
        if (cadena == "")
            ClientToAdd.Observaciones = "Sin Comentarios";
        else
            ClientToAdd.Observaciones = cadena;

        drawBottom();

        return ClientToAdd;
    }

    private int searchText()
    {
        resetConsole();
        Console.Write("Text to search: ");
        string text = Console.ReadLine().ToLower();

        Console.WriteLine("From this file or begining? file/begining");
        string index = Console.ReadLine();

        Console.WriteLine("Stop when finding a file o when finish? finding/finish");
        string stop = Console.ReadLine();

        int actualPos = 1;
        List<int> foundPositions = new List<int>();
        if (index == "file")
        {
            actualPos = Index;
        }

        bool find = false;
        do
        {
            Cliente clienteActual = Clientes.Get(actualPos);
            if (clienteActual.Nombre.ToLower().Contains(text) ||
                clienteActual.Cif.ToLower().Contains(text) ||
                clienteActual.Ciudad.ToLower().Contains(text) ||
                clienteActual.CodigoPostal.ToString("00000").ToLower().Contains(text) ||
                clienteActual.Pais.ToLower().Contains(text) ||
                clienteActual.Telefono.ToString().ToLower().Contains(text) ||
                clienteActual.Email.ToLower().Contains(text) ||
                clienteActual.Contacto.ToLower().Contains(text) ||
                clienteActual.Observaciones.ToLower().Contains(text))

            {
                if (stop == "finding")
                {
                    find = true;
                }
                foundPositions.Add(actualPos);
            }
            if (!find && actualPos < Clientes.Count)
            {
                actualPos++;
            }
        } while (!find && actualPos < Clientes.Count);

        if (foundPositions.Count > 1)
        {
            Console.Write("Found at positions: ");
            Console.Write(foundPositions[0]);
            for (int i = 1; i < foundPositions.Count; i++)
            {
                Console.Write(", " + foundPositions[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Press enter to return");
            Console.ReadLine();
            return Index;
        }

        return actualPos;
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
                Clientes.Guardar();
                break;
            case ConsoleKey.D1:
                if (Index > 0)
                {
                    Index--;
                }
                break;
            case ConsoleKey.D2:
                if (Index < Clientes.Count-1)
                {
                    Index++;
                }
                break;
            case ConsoleKey.D3:
                Index = JumpIntoClient();
                break;
            case ConsoleKey.D4:
                Index = searchText();
                break;
            case ConsoleKey.D5:
                Clientes.Add(newClient());
                break;
            case ConsoleKey.D6:
                Clientes.Set(Index - 1, modifyClient(Clientes.Get(Index)));
                break;
            default:
                break;
        }
    }
}
