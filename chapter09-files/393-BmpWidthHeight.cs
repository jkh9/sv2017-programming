//Guillermo Pastor Pastor
using System;
using System.IO;

public class BmpWidthHeightFS
{
    public static void Main()
    {
        Console.Write("File to read. ");
        string filename = Console.ReadLine();

        const int HEADER_SIZE = 54;
        FileStream input = File.OpenRead(filename);
        byte[] b = new byte[HEADER_SIZE];
        int amount = input.Read(b, 0, HEADER_SIZE);
        input.Close();
        
        if (amount != HEADER_SIZE)
            Console.WriteLine("Read fail!");
        else
        {
            if (b[0] == 'B' && b[1] == 'M')
            {
                Console.WriteLine("This file is a BMP file!");
                int width = 
                    b[18] 
                    + b[19]*256 
                    + b[20]*256*256 
                    + b[21]*256*256*256;
                int height = 
                    b[22] 
                    + b[23]*256
                    + b[24]*256*256
                    + b[25]*256*256*256;
                Console.WriteLine("Width = "+width);
                Console.WriteLine("Height = "+height);
            }
            else
            {
                Console.WriteLine("This file is another type of file...");
            }
        }
    }
}
