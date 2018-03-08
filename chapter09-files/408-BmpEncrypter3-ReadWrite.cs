//Raul Gogna
/*
 *Create a program to encrypt/decrypt a BMP image file, 
 * by changing the "BM" mark in the first two bytes with MB and vice versa.
 */

using System;
using System.IO;

class Ex408
{
    public static void Main(string[] args)
    {
        string inputname, outputname;

        if (args.Length != 2)
        {
            Console.Write("Enter input file: ");
            inputname = Console.ReadLine();
            Console.Write("Enter output file: ");
            outputname = Console.ReadLine();
        }
        else
        {
            inputname = args[0];
            outputname = args[1];
        }

        if (!File.Exists(inputname))
        {
            Console.WriteLine("File not found!");
            return;
        }
        else
        {
            try
            {
                FileStream input = File.Open(
                    inputname, FileMode.Open, FileAccess.ReadWrite);
                byte b1 = (byte)input.ReadByte();
                byte b2 = (byte)input.ReadByte();
                
                input.Seek(0, SeekOrigin.Begin);

                input.WriteByte(b2);
                input.WriteByte(b1);
                
                input.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine("I/O error " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}
