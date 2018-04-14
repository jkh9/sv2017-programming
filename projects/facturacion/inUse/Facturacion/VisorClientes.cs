// Facturación, clase "VisorClientes"

// Versiones:
// V0.01a 11-Abr-2018 Raúl Gogna: Muestra esqueleto, analiza opciones
// V0.01b 14-Abr-2018 Nacho: Crea un dato prefijado, muestra dato y menú

using System;

class VisorClientes
{
    struct DatoCliente
    {
        public string nombre;
        public string cif;
        public string domicilio;
        public string ciudad;
        public string codigoPostal;
        public string pais;
        public string telefono;
        public string email;
        public string contacto;
        public string observaciones;
    }

    public void Ejecutar()
    {
        DatoCliente cliente;
        cliente.nombre = "Nombre";
        cliente.cif = "Cif";
        cliente.domicilio = "Su domicilio";
        cliente.ciudad = "Su ciudad";
        cliente.codigoPostal = "C.P.";
        cliente.pais = "Su país";
        cliente.telefono = "Tlf";
        cliente.email = "email";
        cliente.contacto = "Contacto";
        cliente.observaciones = "Observ.";

        bool exit = false;
        do
        {
            Console.WriteLine("Clientes (ficha actual: )      " + DateTime.Now);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Nombre: " + cliente.nombre);
            Console.WriteLine("DNI / CIF: " + cliente.ciudad);
            Console.WriteLine();
            Console.WriteLine("Domicilio: " + cliente.domicilio);
            Console.WriteLine("Ciudad: " + cliente.ciudad);
            Console.WriteLine("Cod.Postal: " + cliente.codigoPostal);
            Console.WriteLine("Pais: " + cliente.pais);
            Console.WriteLine("Teléfono: " + cliente.telefono);
            Console.WriteLine("E-mail: " + cliente.email);
            Console.WriteLine("Contacto: " + cliente.contacto);
            Console.WriteLine();
            Console.WriteLine("Observaciones: " + cliente.observaciones);

            //Console.SetCursorPosition(0, Console.WindowHeight);
            Console.WriteLine();
            Console.WriteLine("1-Anterior  2-Posterior  3-Número  4-Buscar  5-Añadir  6-Modificar  B-Borrar");
            Console.WriteLine("7-Listados  F1-Ayuda  0-Terminar");
            string line = Console.ReadLine();

            switch (line)
            {
                //Anterior
                case "1":
                    break;
                //Posterior
                case "2":
                    break;
                //Numero
                case "3":
                    break;
                //Buscar
                case "4":
                    break;
                //Añadir
                case "5":
                    break;
                //Modificar
                case "6":
                    break;
                //Borrar
                case "B":
                    break;
                //Listados
                case "7":
                    break;
                //Ayuda
                case "F1":
                    break;
                //Terminar
                case "0":
                    exit = true;
                    break;
                default:
                    break;
            }
        } while (!exit);
    }
}
