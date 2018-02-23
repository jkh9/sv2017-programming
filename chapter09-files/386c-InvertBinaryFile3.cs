/*
Create a program to "invert" a file, using a "FileStream": create a file with 
the same name ending in ".inv" and containing the same bytes as the original 
file but in reverse order (the first byte will be the last, the second will be 
the penultimate, and so on, until the last byte of the original file, which 
should appear in the first position of the resulting file).

In this version, you must read the original file one byte at a time, from end 
to beginning.
*/

//Moisés Encinas Picazo
// Version 3, using a List<byte>

using System;
using System.Collections.Generic;
using System.IO;

public class Clase
{
    public static void Main()
    {
        FileStream file;
        byte line;

        Console.WriteLine("Fichero: ");
        string name = Console.ReadLine();

        if (!File.Exists(name))
        {
            Console.WriteLine("Doesn't exist");
        }
        else
        {
            try
            {
                file = new FileStream(name,FileMode.Open);
                List<byte> datos = new List<byte>();

                for (int i = 0; i < file.Length; i++)
                {
                    datos.Add((byte)file.ReadByte());
                }

                file.Close();

                file = new FileStream(name +".dat ", FileMode.Create);
                for (int i = datos.Count - 1; i >= 0 ; i--)
                {
                    file.WriteByte(datos[i]);
                }
                file.Close();
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("Path too long");
            }
            catch (IOException)
            {
                Console.WriteLine("Fail reading");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: "+ e);
            }
        }
    }
}
