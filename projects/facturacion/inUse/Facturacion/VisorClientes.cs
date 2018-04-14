// Facturación, clase "VisorClientes"

// Versiones:
// V0.01a 11-Abr-2018 Raúl Gogna: Muestra esqueleto, analiza opciones
// V0.01b 14-Abr-2018 Nacho: Crea un dato prefijado, muestra dato y menú
// V0.03a 14-Abr-2018 Raúl Gogna, correcciones por Nacho: 
//            Ver, anterior, posterior, añadir

using System;

class VisorClientes
{
    private ListaDeClientes clientes;
    private int clienteActual;

    public VisorClientes()
    {
        clientes = new ListaDeClientes();
    }

    public void Ejecutar()
    {
        bool terminado = false;
        do
        {
            Console.Clear();
            Console.WriteLine("Clientes (ficha actual: "+
                (clienteActual+1)+
                ")      " + DateTime.Now);
            MostrarClienteActual();
            MostrarMenuInferior();
                       
            string line = Console.ReadLine();

            switch (line)
            {
                //Anterior
                case "1":
                    if (clienteActual > 0) clienteActual--;
                    break;
                //Posterior
                case "2":
                    if (clienteActual < clientes.Count-1) clienteActual++;
                    break;
                //Numero
                case "3":
                    // TO DO
                    break;
                //Buscar
                case "4":
                    // TO DO
                    break;
                //Añadir
                case "5":
                    AnadirCliente();
                    break;
                //Modificar
                case "6":
                    // TO DO
                    break;
                //Borrar
                case "B":
                    // TO DO
                    break;
                //Listados
                case "7":
                    // TO DO
                    break;
                //Ayuda
                case "F1":
                    // TO DO
                    break;
                //Terminar
                case "0":
                    terminado = true;
                    break;
                default:
                    break;
            }
        } while (!terminado);
    }

    public void MostrarClienteActual()
    {
        //To do: Top line
        if (clientes.Count == 0)
        {
            Console.WriteLine("(Aún no hay datos)");
            return;
        }

        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("Nombre: ");
        Console.ResetColor();
        Console.Write("  ");
        if (clientes.Get(clienteActual).Nombre == "")
            clientes.Get(clienteActual).Nombre = "Por Confirmar";
        Console.WriteLine(clientes.Get(clienteActual).Nombre);

        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("Cif: ");
        Console.ResetColor();
        Console.Write("  ");
        if (clientes.Get(clienteActual).Cif == "")
            clientes.Get(clienteActual).Cif = "Por Confirmar";
        Console.WriteLine(clientes.Get(clienteActual).Cif);
        Console.WriteLine();

        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("Domicilio: ");
        Console.ResetColor();
        Console.Write("  ");
        if (clientes.Get(clienteActual).Domicilio == "")
            clientes.Get(clienteActual).Domicilio = "Por Confirmar";
        Console.WriteLine(clientes.Get(clienteActual).Domicilio);

        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("Ciudad: ");
        Console.ResetColor();
        Console.Write("  ");
        if (clientes.Get(clienteActual).Ciudad == "")
            clientes.Get(clienteActual).Ciudad = "Por Confirmar";
        Console.WriteLine(clientes.Get(clienteActual).Ciudad);

        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("Cod.Postal: ");
        Console.ResetColor();
        Console.Write("  ");
        if (clientes.Get(clienteActual).CodigoPostal == "")
            clientes.Get(clienteActual).CodigoPostal = "Por Confirmar";
        Console.WriteLine(clientes.Get(clienteActual).CodigoPostal);

        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("País: ");
        Console.ResetColor();
        Console.Write("  ");
        if (clientes.Get(clienteActual).Pais == "")
            clientes.Get(clienteActual).Pais = "Por Confirmar";
        Console.WriteLine(clientes.Get(clienteActual).Pais);

        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("Teléfono: ");
        Console.ResetColor();
        Console.Write("  ");
        if (clientes.Get(clienteActual).Telefono == "")
            clientes.Get(clienteActual).Telefono = "Por Confirmar";
        Console.WriteLine(clientes.Get(clienteActual).Telefono);

        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("E-mail: ");
        Console.ResetColor();
        Console.Write("  ");
        if (clientes.Get(clienteActual).Email == "")
            clientes.Get(clienteActual).Email = "Por Confirmar";
        Console.WriteLine(clientes.Get(clienteActual).Email);

        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("Contacto: ");
        Console.ResetColor();
        Console.Write("  ");
        if (clientes.Get(clienteActual).Contacto == "")
            clientes.Get(clienteActual).Contacto = "Por Confirmar";
        Console.WriteLine(clientes.Get(clienteActual).Contacto);
        Console.WriteLine();

        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Observaciones: ");
        Console.ResetColor();
        Console.Write("  ");
        if (clientes.Get(clienteActual).Observaciones == "")
            clientes.Get(clienteActual).Observaciones = "Sin observaciones";
        Console.WriteLine(clientes.Get(clienteActual).Observaciones);
    }

    public void MostrarMenuInferior()
    {
        Console.SetCursorPosition(0, Console.WindowHeight - 4);
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.WriteLine(new string('-', 78));
        Console.SetCursorPosition(0, Console.WindowHeight - 3);
        Console.WriteLine("1-Anterior  2-Posterior  3-Número(*)  4-Buscar(*)  5-Añadir  6-Modificar(*)  B-Borrar(*)");
        Console.WriteLine("7-Listados(*)  F1-Ayuda(*)  0-Terminar");
        Console.SetCursorPosition(0, Console.WindowHeight - 2);
        Console.ResetColor();
    }

    public void AnadirCliente()
    {
        Console.Clear();
        Console.Write("Name: ");
        string nombre = Console.ReadLine();

        Console.Write("Cif: ");
        string cif = Console.ReadLine();

        Console.Write("Domicilio: ");
        string domicilio = Console.ReadLine();

        Console.Write("Ciudad: ");
        string ciudad = Console.ReadLine();

        Console.Write("Codigo Postal: ");
        string codigoPostal = Console.ReadLine();

        Console.Write("Pais: ");
        string pais = Console.ReadLine();

        Console.Write("Teléfono: ");
        string telefono = Console.ReadLine();

        Console.Write("E-mail: ");
        string email = Console.ReadLine();

        Console.Write("Contacto: ");
        string contacto = Console.ReadLine();

        Console.Write("Observaciones: ");
        string observaciones = Console.ReadLine();

        clientes.Add(
            new Cliente(nombre, cif, domicilio, ciudad,
                codigoPostal, pais, telefono, email,
                contacto, observaciones));
    }
}
