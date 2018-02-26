//Almudena Lopez Sanchez
//Feb 26th e (Ex.392) Checking if a BMP is compressed (2, header)

using System;
using System.IO;

public class Ex392
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a name file: ");
        string nameFile = Console.ReadLine();

        if (!File.Exists(nameFile))
            Console.WriteLine("File not found!");
        else
        {
            try
            {
                const int HEADER_SIZE = 54;
                FileStream input = File.OpenRead(nameFile);
                byte[] b = new byte[HEADER_SIZE];
                int amount = input.Read(b, 0, HEADER_SIZE);
                input.Close();
                if (amount != HEADER_SIZE)
                    Console.WriteLine("Read not found!");
                else
                {
                    if (b[0] == 'B' && b[1] == 'M')
                    {
                        Console.WriteLine("This file is a BMP file!");
                        if (b[30] == 0)
                            Console.WriteLine("This file is not compressed");
                        else
                            Console.WriteLine("This file is compressed");
                    }
                    else
                    {
                        Console.WriteLine("This file is another type of file...");
                    }

                }
            }
            catch(IOException e)
            {
                Console.WriteLine("I/O ERROR: " + e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("ERROR: " + e.Message);
            }
        }
    }
}

