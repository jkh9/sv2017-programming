// Facturación, clase "VisorDeClientes"

// Versiones:
// V0.01a 11-Abr-2018 Raúl Gogna: Muestra esqueleto, analiza opciones
// V0.01b 14-Abr-2018 Nacho: Crea un dato prefijado, muestra dato y menú
// V0.03a 14-Abr-2018 Raúl Gogna, correcciones por Nacho: 
//            Ver, anterior, posterior, añadir
// V0.04a 15-Abr-2018 Raúl Gogna, correcciones por Nacho: 
//            Número, buscar, modificar
// V0.07a 17-Abr-2018 Nacho: Renombrado a VisorDeClientes

using System;

class VisorDeClientes
{
    private ListaDeClientes clientes;
    private int clienteActual;

    public VisorDeClientes()
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
                    IrANumero();
                    break;
                //Buscar
                case "4":
                    Buscar();
                    break;
                //Añadir
                case "5":
                    AnadirCliente();
                    break;
                //Modificar
                case "6":
                    Modificar();
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
        Console.WriteLine("1-Anterior  2-Posterior  3-Número  4-Buscar  5-Añadir  6-Modificar  B-Borrar(*)");
        Console.WriteLine("7-Listados(*)  F1-Ayuda(*)  0-Terminar");
        Console.SetCursorPosition(0, Console.WindowHeight - 2);
        Console.ResetColor();
    }
    
    public void MostrarInfoSuperior()
    {
        Console.SetCursorPosition(0,0);
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(new string('_', 79));
        Console.WriteLine("|" + new string('_', 7) + "|");
        Console.Write(new string('|', 1));
        Console.Write(" Clientes (ficha actual: " + (clienteActual + 1) + "/" +
            clientes.Count + ")");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.Write("       " + DateTime.Now + "                       " +
            "|");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(new string('_', 79));
    }

    public void AnadirCliente()
    {
        Console.Clear();
        Console.Write("Nombre: ");
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
    
    public void Buscar()
    {
        Console.Clear();
        bool encontrado = false;
        Console.Write("Texto a buscar? ");
        string str = Console.ReadLine().ToLower();
        Console.WriteLine();
        Console.Write("Buscar desde actual (1) o primer registro (2)? ");
        string option = Console.ReadLine();
        
        int puntoDePartida = 0;
        if (option == "1")
            puntoDePartida = clienteActual;

        for (int i = puntoDePartida; i < clientes.Count; i++)
        {
            if (clientes.Get(i).Nombre.ToLower().Contains(str) ||
                clientes.Get(i).Cif.ToLower().Contains(str) ||
                clientes.Get(i).Domicilio.ToLower().Contains(str) ||
                clientes.Get(i).Ciudad.ToLower().Contains(str) ||
                clientes.Get(i).CodigoPostal.ToLower().Contains(str) ||
                clientes.Get(i).Pais.ToLower().Contains(str) ||
                clientes.Get(i).Telefono.ToLower().Contains(str) ||
                clientes.Get(i).Email.ToLower().Contains(str) ||
                clientes.Get(i).Contacto.ToLower().Contains(str) ||
                clientes.Get(i).Observaciones.ToLower().Contains(str))
            {
                encontrado = true;
                Console.Write("Encontrado. Pulse Intro para ver el registro... ");
                Console.ReadLine();
                clienteActual = i;
                break;
            }
        }

        if (!encontrado)
        {
            Console.Write("No encontrado. Pulse Intro para volver... ");
            Console.ReadLine();
        }
    }
    
    public void Modificar()
    {
        Cliente clienteAModificar = clientes.Get(clienteActual);
        Console.Clear();
        MostrarInfoSuperior();
        
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("Nombre: ");
        Console.Write("  ");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("Introduzca el nuevo nombre (era {0})", 
            clienteAModificar.Nombre);
        string answer = Console.ReadLine();
        if (answer != "")
            clienteAModificar.Nombre = answer;

        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("Cif: ");
        Console.Write("  ");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("Introduzca el nuevo cif (era {0})",
            clienteAModificar.Cif);
        answer = Console.ReadLine();
        if (answer != "")
            clienteAModificar.Cif = answer;

        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("Domicilio: ");
        Console.Write("  ");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("Introduzca el nuevo domicilio (era {0})",
            clienteAModificar.Domicilio);
        answer = Console.ReadLine();
        if (answer != "")
            clienteAModificar.Domicilio = answer;

        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("Ciudad: ");
        Console.Write("  ");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("Introduzca la nueva ciudad (era {0})",
            clienteAModificar.Ciudad);
        answer = Console.ReadLine();
        if (answer != "")
            clienteAModificar.Ciudad = answer;

        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("Cod.Postal: ");
        Console.Write("  ");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("Introduzca el nuevo Cod.Postal (era {0})",
            clienteAModificar.CodigoPostal);
        answer = Console.ReadLine();
        if (answer != "")
            clienteAModificar.CodigoPostal = answer;

        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("Pais: ");
        Console.Write("  ");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("Introduzca el nuevo pais (era {0})",
            clienteAModificar.Pais);
        answer = Console.ReadLine();
        if (answer != "")
            clienteAModificar.Pais = answer;

        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("Teléfono: ");
        Console.Write("  ");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("Introduzca el nuevo teléfono (era {0})",
            clienteAModificar.Telefono);
        answer = Console.ReadLine();
        if (answer != "")
            clienteAModificar.Telefono = answer;

        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("E-mail: ");
        Console.Write("  ");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("Introduzca el nuevo email (era {0})",
            clienteAModificar.Email);
        answer = Console.ReadLine();
        if (answer != "")
            clienteAModificar.Email = answer;

        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("Contacto: ");
        Console.Write("  ");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("Introduzca el nuevo contacto (era {0})",
            clienteAModificar.Contacto);
        answer = Console.ReadLine();
        if (answer != "")
            clienteAModificar.Contacto = answer;

        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("Observaciones: ");
        Console.Write("  ");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("Introduzca las nuevas observaciones (era {0})",
            clienteAModificar.Observaciones);
        answer = Console.ReadLine();
        if (answer != "")
            clienteAModificar.Observaciones = answer;

        clientes.Set(clienteActual, clienteAModificar);
    }
    
    public void IrANumero()
    {
        Console.Clear();
        Console.Write("Número de registro? ");
        int num = Convert.ToInt32(Console.ReadLine()) - 1;
        if (num >= clientes.Count || num < 0)
            Console.WriteLine("Número no válido");
        else
            clienteActual = num;
    }


}
