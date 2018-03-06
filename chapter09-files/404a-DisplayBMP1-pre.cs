//Moisés Encinas Picazo

using System;
using System.Collections.Generic;
using System.IO;

public class Ex404
{
    public static void Main(string[] args)
    {
        string fileName;
        Console.WriteLine("Name of the file");
        fileName = "welcome8.bmp";

        if (!File.Exists(fileName))
        {
            Console.WriteLine("File not found");
        }
        else
        {
            try
            {
                BinaryReader input = new BinaryReader(new FileStream(fileName, FileMode.Open));
                byte b = input.ReadByte();
                byte m = input.ReadByte();

                if (b == 'B' && m == 'M')
                {
                    input.BaseStream.Seek(10,SeekOrigin.Begin);
                    int start = input.ReadInt32();

                    input.BaseStream.Seek(18, SeekOrigin.Begin);
                    int width = input.ReadInt32();

                    input.BaseStream.Seek(start, SeekOrigin.Begin);
                    for (int i = start; i < input.BaseStream.Length; i++)
                    {
                        byte line = input.ReadByte();
                        if ((i+1) % width == width -1)
                        {
                            Console.WriteLine();
                        }
                        if (line > 127)
                        {
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.Write("*");
                        }
                    }
                }
                input.Close();
            }
            catch (IOException)
            {

            }

            catch (Exception e)
            {

            }
        }
    }
}
