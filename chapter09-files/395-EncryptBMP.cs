/*
Create a program to encrypt/decrypt a BMP image file, by changing 
the "BM" mark in the first two bytes with MB and vice versa.

You must dump its contents to a new file. The user must enter 
the names for both files.
*/

using System;
using System.IO;

public class EncryptBMP
{
    public static void Main(string[] args)
    {
        string inputName, outputName;
        
        if (args.Length != 2)
        {
            Console.Write("Input file name?");
            inputName = Console.ReadLine();
            Console.Write("Output file name?");
            outputName = Console.ReadLine();
        }
        else
        {
            inputName = args[0];
            outputName = args[1];
        }

        if (!File.Exists(inputName))
            Console.WriteLine("Input file not found");
        else
        {
            FileStream file = File.OpenRead(inputName);
            int amountToRead = (int) file.Length;
            byte[] data = new byte[amountToRead];
            int result = file.Read(data, 0, amountToRead);
            file.Close();
            
            if (result < 2)
            {
                Console.WriteLine("File is too short!");
                return;
            }
            
            if (! (
                (data[0] == 'B' && data[1] == 'M') ||
                (data[0] == 'M' && data[1] == 'B') ))
            {
                Console.WriteLine("Not a valid BMP!");
                return;
            }
            
            byte aux = data[0];
            data[0] = data[1];
            data[1] = aux;

            FileStream output = File.OpenWrite(outputName);
            output.Write(data, 0, result);
            output.Close();
        }
    }
}
