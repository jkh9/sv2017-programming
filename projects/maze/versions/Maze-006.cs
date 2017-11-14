/*
 *  Maze Game
 * 
 *  V0.01 20-Sep-2017 Francisco Sabater: Main menu
 *  V0.02 29-Sep-2017 Gonzalo Martinez: Main menu do-while
 *  V0.03 11-Oct-2017 Javier Herreros: Main menu + switch
 *  V0.04 13-Oct-2017 Lucía Navarro: Main menu + switch + New Game
 *  V0.05 13-Nov-2017 Marcos Cervantes, Guillermo Pastor: Map as bidim Array
 *  V0.06 13-Nov-2017 Victor Tebar: User can turn and move forward
 */

using System;

public class Maze
{
    enum orientations { NORTH, EAST, SOUTH, WEST };

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
                    int x = 0, y = 2; // Starting room
                    byte orientation = (byte) orientations.NORTH;
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

                        Console.Write("You are facing ");
                        Console.WriteLine((orientations)orientation);

                        if (map[y, x].Contains("U"))
                            Console.Write("Door North. ");
                        if (map[y, x].Contains("D"))
                            Console.Write("Door South. ");
                        if (map[y, x].Contains("R"))
                            Console.Write("Door East. ");
                        if (map[y, x].Contains("L"))
                            Console.Write("Door West. ");
                        Console.WriteLine();

                        Console.Write("What now (\"end\" to finish)? ");
                        answer = Console.ReadLine();
                        Console.Clear();

                        if (answer.ToLower() == "turn right")
                        {
                            orientation++;
                            if (orientation > 3)
                                orientation = 0;
                        }
                        else if (answer.ToLower() == "turn left")
                        {
                            orientation--;
                            if (orientation < 0)
                                orientation = 3;
                        }
                        else if (answer.ToLower() == "walk")
                        {
                            if (orientation == (byte) orientations.SOUTH &&
                                map[y, x].Contains("D"))
                                y++;
                            else if (orientation == (byte)orientations.WEST &&
                                map[y, x].Contains("L"))
                                x--;
                            else if (orientation == (byte)orientations.NORTH &&
                                map[y, x].Contains("U"))
                                y--;
                            else if (orientation == (byte)orientations.EAST &&
                                map[y, x].Contains("R"))
                                x++;
                            else
                                Console.WriteLine("You can't walk that way");
                        }
                        else
                            Console.WriteLine("Unknown command");

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
