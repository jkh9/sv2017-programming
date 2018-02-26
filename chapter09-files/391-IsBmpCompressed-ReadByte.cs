//Pedro Luis Coloma

using System;
using System.IO;

public class BMPCompresed
{
    public static void Main()
    {
        Console.Write("Enter a file name: ");
        string name = Console.ReadLine();

        if (!File.Exists(name))
        {
            Console.WriteLine("File not found!");
        }
        else
        {
            try
            {
                FileStream myFile = new FileStream(
                    name, FileMode.Open);
                byte data;
                bool firstLetterCorrect = false;
                bool secondLetterCorrect = false;
                bool compressed = true;                

                data = (byte)myFile.ReadByte();
                if (data == 'B')
                {
                    firstLetterCorrect = true;
                }

                data = (byte)myFile.ReadByte();
                if (data == 'M')
                {
                    secondLetterCorrect = true;
                }

                myFile.Seek(30, SeekOrigin.Begin);
                data = (byte)myFile.ReadByte();
                if (data == 0)
                {
                    compressed = false;
                }
                myFile.Close();
                
                if (firstLetterCorrect && secondLetterCorrect)
                {
                    Console.WriteLine("Seems a real BMP file.");
                    if (compressed)
                    {
                        Console.WriteLine("Its compressed.");
                    }
                    else
                    {
                        Console.WriteLine("It's not compressed.");
                    }
                }
                else
                {
                    Console.WriteLine("It's not an BMP file.");
                }
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("Path too long");
            }
            catch (IOException e)
            {
                Console.WriteLine("I/O error: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Oooops... " + e.Message);
            }
        }
    }
}
