/*
Create a program to "invert" a file, using a "FileStream": create a file with 
the same name ending in ".inv" and containing the same bytes as the original 
file but in reverse order (the first byte will be the last, the second will be 
the penultimate, and so on, until the last byte of the original file, which 
should appear in the first position of the resulting file).

In this version, you must read the original file one byte at a time, from end 
to beginning.
*/

// Brandon Blasco Del Cid
// Version 1, using a Stack

using System;
using System.IO;
using System.Collections;


public class Ex386
{
    public static void Main()
    {
        Console.WriteLine("Introduce un nombre de fichero: ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found!");
        }
        else
        {
            try
            {
                FileStream input = File.OpenRead(filename);
                FileStream output = File.OpenWrite(filename+"2.txt");
                Stack stack = new Stack();
                for (int i = 0; i < input.Length; i++)
                {
                    byte line = (byte)input.ReadByte();
                    stack.Push(line);
                   
                }
                int amount = stack.Count;
                for (int i = 0; i < amount; i++)
                {
                    output.WriteByte((byte)stack.Pop());
                }
                input.Close();
                output.Close();
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("Ruta del fichero inaccesible");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Fichero no encontrado");
            }
            catch (IOException e)
            {
                Console.WriteLine("I/O Error: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Oppss... " + e.Message);
            }
        }
    }
}
