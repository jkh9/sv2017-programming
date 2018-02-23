/*
Create a program to "invert" a file, using a "FileStream": create a file with 
the same name ending in ".inv" and containing the same bytes as the original 
file but in reverse order (the first byte will be the last, the second will be 
the penultimate, and so on, until the last byte of the original file, which 
should appear in the first position of the resulting file).

In this version, you must read the original file one byte at a time, from end 
to beginning.
*/

// Version 5, dumping to an array of bytes, one byte at a time

using System;
using System.IO;

public class InvertBinaryFile
{
    public static void Main()
    {
        Console.Write("File name? ");
        string fileName = Console.ReadLine();
        if (!File.Exists(fileName))
        {
            Console.Write("That file doesnt exist");
        }
        else
        {
            try
            {
                FileStream readFile = File.OpenRead(fileName);
                FileStream writeFile = File.Create("inverted.inv");
                byte[] data = new byte[readFile.Length];

                for (int i = 0; i < readFile.Length; i++)
                {
                    data[i] = (byte) readFile.ReadByte();
                }

                for (int i = data.Length - 1; i >= 0; i--)
                {
                    writeFile.WriteByte(data[i]);
                }

                writeFile.Close();
                readFile.Close();
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("Path too long");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File no accessible");
            }
            catch (IOException e)
            {
                Console.WriteLine("I/O error: " + e);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
            }
        }
    }
}
