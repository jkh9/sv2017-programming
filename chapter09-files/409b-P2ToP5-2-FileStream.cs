//Moisés Encinas Picazo

using System;
using System.Collections.Generic;
using System.IO;

public class Ex409
{
    public static void Main(string[] args)
    {
        Console.WriteLine("File name: ");
        string fileName = "ap2.pgm";

        if (!(File.Exists(fileName)))
        {
            Console.WriteLine("Doesn't exist the file");
        }
        else
        {
            try
            {
                FileStream input = new FileStream(fileName, FileMode.Open);
                byte[] data = new byte[input.Length];
                input.Read(data, 0, (int) input.Length);
                input.Close();

                FileStream output = new FileStream("p5asdf.pgm", FileMode.Create);

                int dataCount = 0;

                if (!(data[0] == 'P' && data[1] == '2'))
                {   
                    Console.WriteLine("Invalid format");
                }
                else
                {
                    dataCount = 3;
                    string line = "";

                    // Width
                    do
                    {
                        if (data[dataCount] != ' ')
                        {
                            line += (char) data[dataCount];
                            dataCount++;
                        }
                    } while (data[dataCount]!= ' ');
                    dataCount++;
                    string width = line;

                    // Height
                    line = "";
                    do
                    {
                        if (data[dataCount] != 10)
                        {
                            line +=  (char) data[dataCount];
                            dataCount++;
                        }
                    } while (data[dataCount]!= 10);
                    dataCount++;
                    string height = line;

                    // Amount of greys
                    line = "";
                    do
                    {
                        if (data[dataCount] != 10)
                        {
                            line += (char)data[dataCount];
                            dataCount++;
                        }
                    } while (data[dataCount] != 10);
                    dataCount++;
                    string numberFormat = line;
                    if (numberFormat != "255")
                    {
                        Console.WriteLine("Invalid format");
                    }
                    else
                    {
                        // First line of the header
                        output.WriteByte((byte)'P');
                        output.WriteByte((byte)'5');
                        output.WriteByte(10);
                        
                        // Width and height
                        for (int i = 0; i < width.Length; i++)
                        {
                            output.WriteByte((byte)width[i]);
                        }
                        output.WriteByte((byte)' ');
                        for (int i = 0; i < height.Length; i++)
                        {
                            output.WriteByte((byte)height[i]);
                        }
                        output.WriteByte(10);
                        
                        // Amount of greys
                        output.WriteByte((byte)'2');
                        output.WriteByte((byte)'5');
                        output.WriteByte((byte)'5');
                        output.WriteByte(10);

                        // And data
                        do
                        {
                            if (data[dataCount] != 10)
                            {
                                line = "";
                                do
                                {
                                    if ((data[dataCount] != ' ')
                                        && (data[dataCount] != 10))
                                    {
                                        line += (char)data[dataCount];
                                        dataCount++;
                                    }
                                } while ((data[dataCount] != ' ')
                                    && (data[dataCount] != 10));
                                dataCount++;
                                output.WriteByte(Convert.ToByte(line));
                            }
                        } 
                        //while (data[dataCount] != 10);
                        while ( dataCount < input.Length );
                        
                        output.Close();
                    }
                }
            }
            catch (IOException)
            {
                Console.WriteLine("Error reading or writing");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: "+e.Message);
            }
        }
    }
}
