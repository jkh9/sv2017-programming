// Extract text from a binary file

// Brandon Blasco Del Cid

using System;
using System.IO;

public class Ex382
{
    public static void Main()
    {
        Console.Write("Enter file name: ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found!");
        }
        else
        {
            try
            {
                FileStream myFile = File.OpenRead(filename);
                StreamWriter output = File.CreateText(filename+".txt");

                for (int i = 0; i < myFile.Length; i++)
                {
                    byte data = (byte)myFile.ReadByte();
                    if ((data >= 32 && data <=126) 
                            || (data == 13) || (data == 10))
                        output.Write((char)data);
                }
                output.Close();
                myFile.Close();
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("Path too long");
            }
            catch (IOException e)
            {
                Console.WriteLine("I/O Error: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }
        }
    }
}
