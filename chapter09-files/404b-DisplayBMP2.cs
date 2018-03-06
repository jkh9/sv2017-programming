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
                    List<string> data = new List<string>();
                    string line = "";
                    for (int i = start; i < input.BaseStream.Length; i++)
                    {
                        byte bite = input.ReadByte();
                        if ((i+1) % width == width -1)
                        {
                            data.Add(line);
                            line = "";
                            Console.WriteLine();
                        }
                        if (bite > 127)
                        {
                            line += " ";
                        }
                        else
                        {
                            line += "*";
                        }
                    }

                    for (int i = data.Count - 1; i >= 0; i--)
                    {
                        Console.WriteLine(data[i]);
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
