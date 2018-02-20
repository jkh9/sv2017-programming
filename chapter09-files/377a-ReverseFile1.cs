// Ex.377 - Invert a file (Exists + try-catch)

// Create a program to ask the user for the name of a file 
// and display it reversed (you must use "File.Exists" and "try-catch"

// Raul Gogna

using System;
using System.IO;
using System.Collections;

class ReverseAFile
{
    public static void Main()
    {
        StreamReader reader;
        Console.Write("Enter name of file: ");
        string filename = Console.ReadLine();
        if (! File.Exists(filename))
            Console.WriteLine("File not exist");
        else
        {
            try
            {
                reader = new StreamReader(filename);
                Stack myStack = new Stack();
                string line;
                do
                {
                    line = reader.ReadLine();
                    if (line != null)
                    {
                        myStack.Push(line);
                    }
                } while (line != null);
                reader.Close();
                
                while (myStack.Count > 0)
                {
                    Console.WriteLine(myStack.Pop());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Ooops... {0}", e.Message);
            }
        }
    }
}
