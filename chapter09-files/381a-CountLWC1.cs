/*
Cout lines, words and chars in a text file.
(Simplified version: assuming there are no pairs of spaces)
*/

using System;
using System.IO;

public class CountLWC
{
    public static void Main()
    {
        Console.Write("Enter file name: ");
        string name = Console.ReadLine();
        if (!File.Exists(name))
            Console.WriteLine("File not found!");
        else
        {
            try
            {
                StreamReader input = new StreamReader(name);
                int numLines = 0;
                int numWords = 0;
                int numChars = 0;
                string line = input.ReadLine();
                while (line != null)
                {
                    numLines ++;
                    numWords += line.Split().Length;
                    numChars += line.Length;
                } 
                input.Close();
                Console.WriteLine("Lines: " + numLines);
                Console.WriteLine("Words: " + numWords);
                Console.WriteLine("Chars: " + numChars);
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
