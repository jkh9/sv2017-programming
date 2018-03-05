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

using System;
using System.IO;

public class DbfReader
{
    public static void Main(string[] args)
    {
        const int HEADER_SIZE = 32;
        const int NAME_LENGTH = 11;
        const int POS_OF_SIZE = 8;
            
        string fileName;
        if (args.Length != 1)
        {
            Console.Write("Enter the name of the DBF file: ");
            fileName = Console.ReadLine();
        }
        else
            fileName = args[0];

        if (!File.Exists(fileName))
        {
            Console.WriteLine("The file doesnt exists");
        }
        else
        {
            try
            {
                BinaryReader file = new BinaryReader(
                    File.Open(fileName, FileMode.Open));

                file.BaseStream.Seek(POS_OF_SIZE, SeekOrigin.Begin);

                int headerBytes = file.ReadInt16();
                int fields = headerBytes / HEADER_SIZE;

                file.BaseStream.Seek(HEADER_SIZE, SeekOrigin.Begin);
                for (int i = 0; i < fields-1; i++ )
                {
                    string fieldName = "";
                    for ( int j = 0; j < NAME_LENGTH; j++)
                    {
                        fieldName += (char)file.ReadByte();
                    }
                    Console.WriteLine("{0}: {1}", i+1, fieldName);
                    file.BaseStream.Seek(HEADER_SIZE - NAME_LENGTH, 
                        SeekOrigin.Current);
                }
                file.Close();
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("Path too long");
            }
            catch (IOException ex)
            {
                Console.WriteLine("Input/output error: {0}", ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected error: {0}", ex.Message);
            }
        }
    }
}
