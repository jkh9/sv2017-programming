/*
Create a program to "invert" a file, using a "FileStream": create a file with 
the same name ending in ".inv" and containing the same bytes as the original 
file but in reverse order (the first byte will be the last, the second will be 
the penultimate, and so on, until the last byte of the original file, which 
should appear in the first position of the resulting file).

In this version, you must read the original file one byte at a time, from end 
to beginning.
*/

// Javier Saorín Vidal
// Version 4, reading and writing one byte at a time

using System;
using System.IO;

class FileInverter
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
                FileStream input =
                    new FileStream(fileName, FileMode.Open);
                FileStream output = File.Create(fileName + ".inv");

                for (long i = input.Length - 1; i >= 0; i--)
                {
                    input.Seek(i, SeekOrigin.Begin);
                    byte b = (byte)input.ReadByte();
                    output.WriteByte(b);
                }

                input.Close();
                output.Close();
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
