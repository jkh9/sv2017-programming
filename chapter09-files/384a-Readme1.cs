//Moisés Encinas Picazo

using System;
using System.Collections.Generic;
using System.IO;

public class Clase
{
    public static void Main()
    {
        ConsoleKeyInfo k;
        bool exit = false;

        List<string> text = new List<string>();

        Console.WriteLine("Name of the file: ");
        string name = Console.ReadLine();
        

        if (File.Exists(name))
        {
            try
            {
                StreamReader input = new StreamReader(name);

                string line;
                do
                {
                    line = input.ReadLine();
                    if (line != null)
                    {
                        text.Add(line);
                    }
                } while (line != null);

                input.Close();
            }
            catch (PathTooLongException)
            {

            }
            catch (IOException)
            {

            }
            catch (Exception)
            {

            }
        }
        else
        {
            Console.WriteLine("No existe loco");
        }
        int actualLine = 0;
        do
        {
            Console.Clear();
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(text[(actualLine + i)]);
            }
            System.Threading.Thread.Sleep(10);

            do
            {
                k = Console.ReadKey(false);
            } while (Console.KeyAvailable);

            switch (k.Key)
            {
                case ConsoleKey.UpArrow:
                    if (actualLine > 0)
                    {
                        actualLine--;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (actualLine < (text.Count - 20))
                    {
                        actualLine++;
                    }
                    break;
                case ConsoleKey.Home:
                    actualLine = 0;
                    break;
                case ConsoleKey.End:
                    actualLine = text.Count - 20;
                    break;
                case ConsoleKey.PageUp:
                    if (actualLine > 19)
                    {
                        actualLine-= 20;
                    }
                    else
                    {
                        actualLine = 0;
                    }
                    break;
                case ConsoleKey.PageDown:
                    if (actualLine < (text.Count - 40))
                    {
                        actualLine+= 20;
                    }
                    else
                    {
                        actualLine = text.Count - 20;
                    }
                    break;
                case ConsoleKey.F1:
                    Console.Clear();
                    Console.WriteLine("Holaaa ");
                    Console.ReadLine();
                    break;
                case ConsoleKey.Escape:
                    exit = true;
                    break;
                default:
                    break;
            }
        } while (!exit);
        
    }
}