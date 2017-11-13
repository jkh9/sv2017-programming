/*
 *  Maze Game
 * 
 *  V0.01 20-Sep-2017 Francisco Sabater: Main menu
 *  V0.02 29-Sep-2017 Gonzalo Martinez: Main menu do-while
 *  V0.03 11-Oct-2017 Javier Herreros: Main menu + switch
 *  V0.04 13-Oct-2017 Lucía Navarro: Main menu + switch + New Game
 *  V0.05 13-Nov-2017 Marcos Cervantes, Guillermo Pastor: Map as bidim Array
 */

using System;

public class Maze
{
    public static void Main()
    {
        string[,] map =
        {
            {"RD", "LR", "LRD", "LRD", "LD", "D" },
            {"UR", "LRD", "LU", "UR", "LRUD", "LU" },
            {"D", "UD", "R", "LD", "UD", "RD" },
            {"UR", "LUR", "LR", "LU", "UR", "LU" }

        };
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
                        Console.WriteLine("You are facing North. what would you do?");
                        Console.WriteLine("There's an exit in the South.");
                        Console.Write("What now (\"end\" to finish)? ");
                        answer = Console.ReadLine();
                        if (answer != "end")
                        {
                            Console.WriteLine("I can't understand you...");
                        }
                        else
                        {

                        }
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
