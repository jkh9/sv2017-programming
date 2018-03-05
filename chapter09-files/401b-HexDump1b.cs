// Hex file dumper, v1

// Dumps a file in hex
// Approach "b": Reads the whole file

using System;
using System.IO;

public class HexDump
{
    public static void Main(string[] args)
    {
        string fileName;
        if (args.Length > 0)
            fileName = args[0];
        else
        {
            Console.Write("Enter the filename: ");
            fileName = Console.ReadLine();
        }
        
        if (! File.Exists( fileName ))
        {
            Console.WriteLine("File not found!");
        }
        else
        {
            FileStream file = File.OpenRead(fileName);
            int size = (int) file.Length;
            byte[] data = new byte[size];
            int readBytes = file.Read(data, 0, size);
            file.Close();
            
            for (int i = 0; i < size; i++)
            {
                Console.Write(data[i].ToString("x2")+ " ");
                if (i % 16 == 15)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }
    }
}
