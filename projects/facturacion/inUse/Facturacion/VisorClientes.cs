using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class VisorClientes
{
    struct DatosClientes
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


        bool exit = false;
        do
        {
            Console.WriteLine("Clientes (ficha actual: )      " + DateTime.Now);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Nombre: ");
            Console.WriteLine("DNI / CIF: ");
            Console.WriteLine();
            Console.WriteLine("Domicilio: ");
            Console.WriteLine("Ciudad: ");
            Console.WriteLine("Cod.Postal: ");
            Console.WriteLine("Pais: ");
            Console.WriteLine("Teléfono: ");
            Console.WriteLine("E-mail: ");
            Console.WriteLine("Contacto: ");
            Console.WriteLine();
            Console.WriteLine("Observaciones: ");

            //Console.SetCursorPosition(0, Console.WindowHeight);
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
