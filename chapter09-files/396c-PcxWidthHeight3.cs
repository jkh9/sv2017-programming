using System;
using System.IO;

class WidthHeightPCX
{
    static void Main(string[] args)
    {
        string fileName;
        if (args.Length > 0)
            fileName = args[0];
        else
        {
            Console.Write("File name? ");
            fileName = Console.ReadLine();
        }

        if (!File.Exists(fileName))
        {
            Console.WriteLine("File doesn't exist");
        }
        else
        {
            try
            {
                BinaryReader input = new BinaryReader(
                    File.Open(fileName, FileMode.Open));
                byte mark1 = input.ReadByte();
                input.BaseStream.Seek(4, SeekOrigin.Begin);
                short xMin = input.ReadInt16();
                short yMin = input.ReadInt16();
                short xMax = input.ReadInt16();
                short yMax = input.ReadInt16();
                int width = (xMax - xMin) + 1;
                int height = (yMax - yMin) + 1;
                input.Close();

                if (mark1 == 10 )
                {
                    Console.WriteLine("It seems a PCX");

                    Console.WriteLine("Width: " + width);
                    Console.WriteLine("Height: " + height);
                }
                else
                {
                    Console.WriteLine("It's not a PCX");
                }
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("Path too long");
            }
            catch (IOException e)
            {
                Console.WriteLine("Input/output error: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }
        }
    }
}
