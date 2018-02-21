/*
Create a program to read a text file and dump its contents
to another text file, removing the redundant spaces (leading,
trailing and duplicated).
*/

using System;
using System.IO;

public class RedundantSpaces
{
    public static void Main()
    {
        if (!File.Exists("input.txt"))
            Console.WriteLine("File not found!");
        else
        {
            try
            {
                StreamReader input = new StreamReader("input.txt");
                StreamWriter output = new StreamWriter("output.txt");
                string line = input.ReadLine();
                while (line != null)
                {
                    line = line.Trim();
                    while (line.Contains("  "))
                        line = line.Replace("  "," ");
                    output.WriteLine(line);
                } 
                output.Close();
                input.Close();
            }
            catch(IOException e)
            {
                Console.WriteLine("I/O error: "+ e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("Oooops... "+ e.Message);
            }
        }
    }
}
