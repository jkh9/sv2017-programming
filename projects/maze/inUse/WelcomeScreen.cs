/*
 *  Maze Game
 * 
 *  V0.07 19-Dic-2017 Nacho: Almost empty skeleton
 *  V0.12 20-Apr-2018 Daniel, Javier, Gonzalo: welcome screen is read from file
 */

using System;
using System.IO;

public class WelcomeScreen
{
    protected int lineHeight = 0;

    public void Display()
    {
        if (!File.Exists("welcome.txt"))
            Console.WriteLine("Welcome screen file not found!");
        else
        {
            try
            {
                StreamReader input = new StreamReader("welcome.txt");
                string line;
                do
                {
                    line = input.ReadLine();
                    if (line != null)
                    {
                        if ((line.Length < Console.WindowWidth))
                        {
                            if (lineHeight < 23)
                            {
                                Console.SetCursorPosition(15, lineHeight);
                                Console.ForegroundColor = ConsoleColor.Red;
                                lineHeight++;
                                Console.WriteLine(line);
                            }
                            else
                            {
                                Console.SetCursorPosition(0, lineHeight);
                                Console.ForegroundColor = ConsoleColor.Red;
                                lineHeight++;
                                Console.WriteLine(line);
                            }
                        }
                    }
                }
                while (line != null);
                input.Close();
                Console.SetCursorPosition(79, 25);
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadLine();
                Console.Clear();
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("Path too long");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not accessible");
            }
            catch (IOException e)
            {
                Console.WriteLine("I/O error: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}

