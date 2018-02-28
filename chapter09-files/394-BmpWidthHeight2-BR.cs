// Javier Saorín Vidal

using System;
using System.IO;

class BmpTester
{
    public static void Main()
    {
        Console.Write("Enter file name (.bmp): ");
        string fileName = Console.ReadLine();
        
        if (!File.Exists(fileName))
            Console.WriteLine(fileName + " is not a valid file name!");
        else
        {
            try
            {
                BinaryReader input =
                    new BinaryReader(File.Open(fileName, FileMode.Open));

                input.BaseStream.Seek(18, SeekOrigin.Begin);
                int width = input.ReadInt32();

                // input.BaseStream.Seek(22, SeekOrigin.Begin); // Not needed.
                int height = input.ReadInt32();
                input.Close();

                Console.WriteLine("Width: " + width);
                Console.WriteLine("Height: " + height);
  
            }
            catch (PathTooLongException pl)
            {
                Console.WriteLine("PATH TOO LONG EXCEPTION: " + pl.Message);
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
