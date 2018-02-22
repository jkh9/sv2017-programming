//Luis Selles, Javier Saorin, Almudena Lopez

using System;
using System.IO;

class Readme
{
    static void Main()
    {
		Console.WriteLine("Name of the file: ");
        string name = Console.ReadLine();
        if (!File.Exists(name))
        {
            Console.WriteLine("File not found!");
        }
        else
        {
            try
            {
                bool exit = false;
                string[] lines = File.ReadAllLines(name);
                int actualPos = 0;
                do
                {    
                    for (int i = actualPos; i < (actualPos + 25); i++)
                        Console.WriteLine(lines[i]);

                    ConsoleKeyInfo key = Console.ReadKey();

                    if (key.Key == ConsoleKey.Escape)
                    {
                        exit = true;
                    }
                    else if (key.Key == ConsoleKey.UpArrow)
                    {
                        if (actualPos > 0)
                        {
                            actualPos--;
                        }
                    }
                    else if (key.Key == ConsoleKey.DownArrow)
                    {
                        if (actualPos < lines.Length - 25)
                        {
                            actualPos++;
                        }
                    }
                    else if (key.Key == ConsoleKey.Home)
                    {
                        actualPos = 0;
                    }
                    else if (key.Key == ConsoleKey.End)
                    {
                        actualPos = lines.Length - 25;
                    }
                    else if (key.Key == ConsoleKey.PageDown)
                    {
                        if (actualPos < lines.Length - 25)
                        {
                            actualPos += 20;
                        }
                    }
                    else if (key.Key == ConsoleKey.PageUp)
                    {
                        if (actualPos > 21)
                        {
                            actualPos -= 20;
                        }
                    }
                }
                while (!exit);
            }
            catch (IOException e)
            {
                Console.WriteLine("ERROR: " +  e.Message);
            } 
            catch(Exception e )
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
