/*
 *  Maze Game
 * 
 *  V0.01 20-Sep-2017 Francisco Sabater: Main menu
 *  V0.02 29-Sep-2017 Gonzalo Martinez: Main menu do-while
 *  V0.03 11-Oct-2017 Javier Herreros: Main menu + switch
 *  V0.04 13-Oct-2017 Lucía Navarro: Main menu + switch + New Game
 */

using System;

public class Maze
{
    public static void Main()
    {
        char option;

        do
        {
            Console.WriteLine("1.- New Game.");
            Console.WriteLine("2.- Load Game.");
            Console.WriteLine("3.- Help.");
            Console.WriteLine("4.- Credits.");
            Console.WriteLine("5.- Options.");
            Console.WriteLine("X.- Exit.");

            Console.Write("Select an option: ");
            option = Convert.ToChar(Console.ReadLine());

            switch (option)
            {
                case '1':
                    string answer;
                    do
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine();
                        Console.WriteLine(" \\                   /");
                        Console.WriteLine("  \\                 /");
                        Console.WriteLine("   -----------------");
                        Console.WriteLine("  |                 |");
                        Console.WriteLine("  |                 |");
                        Console.WriteLine("  |        ___      |");
                        Console.WriteLine("  |       |   |     |");
                        Console.WriteLine("  |       |   |     |");
                        Console.WriteLine("   -----------------");
                        Console.WriteLine("  /                 \\");
                        Console.WriteLine(" /                   \\");
                        Console.WriteLine();
                        Console.ResetColor();
                        Console.Write("What now (\"end\" to finish)? ");
                        answer = Console.ReadLine();
                        if (answer != "end")
                            Console.WriteLine("I can't understand you...");
                    }
                    while (answer != "end");
                    break;
                case '2':
                    Console.WriteLine();
                    Console.WriteLine("Option not available... yet");
                    Console.WriteLine();
                    break;
                case '3':
                    Console.WriteLine();
                    Console.WriteLine("Option not available... yet");
                    Console.WriteLine();
                    break;
                case '4':
                    Console.WriteLine();
                    Console.WriteLine("Option not available... yet");
                    Console.WriteLine();
                    break;
                case '5':
                    Console.WriteLine();
                    Console.WriteLine("Option not available... yet");
                    Console.WriteLine();
                    break;
                case 'x':
                case 'X':
                    Console.WriteLine("Bye!");
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("Wrong option");
                    Console.WriteLine();
                    break;
            }
        }
        while ((option != 'x') && (option != 'X'));
    }
}
