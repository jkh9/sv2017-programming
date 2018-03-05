/*
Crea un programa que muestre la lista de los campos que hay almacenados 
en un fichero DBF:

El formato DBF es el usado por el antiguo gestor de bases de datos 
dBase, y soportado como formato de exportación por muchas herramientas 
actuales, como Excel o Access. 

Los archivos DBF se dividen en dos partes: una cabecera que almacena 
información sobre la estructura del archivo y una zona de datos.

La zona de cabecera se separa de la zona de datos con el carácter CR 
(avance de carro, número 13 del código ASCII). A su vez la cabecera se 
divide en dos partes: la primera ocupa 32 bytes y contiene información 
general sobre el archivo, mientras que la segunda contiene información 
sobre cada campo y está formada por tantos bloques de 32 bytes como 
campos tenga la tabla.

La cabecera general del archivo es:
Posicion        Tamaño (bytes)   Descripcion
     1                1          Producto con el fue creada la tabla
     2                3          Fecha ultima actualizacion año/mes/dia
     5                4          Nro.total de registros de la tabla
     9                2          Longitud total de la cabecera incluido CR
    11                2          Longitud del registro
    13                2          Reservados
    15                1          Flag de Transaccion activa
    16                1          Flag de encriptacion
    17               12          Indicadores para el uso en red
    29                1          Flag de fichero de indica .MDX
    30                3          Reservados
    
La cabecera de cada campo es:
Posicion        Tamaño (bytes)   Descripcion
   1                  11         Nombre de Campo
  12                   1         Tipo de campo (C,D,F,L,M,N)
  13                   4         Reservados
  17                   1         Longitud de campo
  18                   1         Numero de decimales si el campo numerico
  19                   2         Reservados
  21                   1         Flag de area de trabajo
  22                  10         Reservados
  32                   1         Flag de inclusion en el indice .MDX
    
(Se puede observar que la cantidad de campos no se indica en la 
cabecera, pero se puede deducir, sabiendo la longitud de la cabecera, 
que está en las posiciones 9 y 10, y el tamaño de cada bloque de 
cabecera, que es de 32 bytes).
*/

// Fields of a DBF file, using BinaryReader

// Javier Saorín Vidal

using System;
using System.IO;

class DBFFIelds
{
    public static void Main()
    {
        Console.Write("Enter file name: ");
        string fileName = Console.ReadLine();
        
        if (!File.Exists(fileName))
            Console.WriteLine(fileName + " is not a valid file name!");
        else
        {
            try
            {
                BinaryReader input =
                    new BinaryReader(File.Open(fileName, FileMode.Open));

                input.BaseStream.Seek(8, SeekOrigin.Begin);
                int size = input.ReadInt16();
                int fields = size / 32 - 1;

                for (int i = 1; i <= fields; i++)
                {
                    input.BaseStream.Seek(i * 32, SeekOrigin.Begin);
                    string name = "";

                    for (int j = 0; j < 11; j++)
                        name += (char)input.ReadByte();

                    Console.WriteLine("Field " + i + ": " + name);
                }
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("PATH TOO LONG");
            }
            catch (IOException ioEx)
            {
                Console.WriteLine("INPUT/OUTPUT ERROR: " + ioEx.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR: " + e.Message);
            }
        }
    }
}
