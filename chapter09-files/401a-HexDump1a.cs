// Hex file dumper, v1

// Dumps a file in hex
// Approach "a": Reads blocks of 16 bytes

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
            int blockSize = 16;
            byte[] data = new byte[blockSize];
            
            int readBytes;
            do
            {
                readBytes = file.Read(data, 0, blockSize);
                for(int i = 0 ; i < readBytes ; i++)
                {
                    Console.Write(data[i].ToString("x2")+ " ");
                }
                Console.WriteLine();
            }
            while (readBytes == blockSize);
            
            file.Close();
        }
    }
}
