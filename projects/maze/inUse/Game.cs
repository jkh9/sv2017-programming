/*
 *  Maze Game
 * 
 *  V0.01 20-Sep-2017 Francisco Sabater: Main menu
 *  V0.02 29-Sep-2017 Gonzalo Martinez: Main menu do-while
 *  V0.03 11-Oct-2017 Javier Herreros: Main menu + switch
 *  V0.04 13-Oct-2017 Lucía Navarro: Main menu + switch + New Game
 *  V0.05 13-Nov-2017 Marcos Cervantes, Guillermo Pastor: Map as bidim Array
 *  V0.06 13-Nov-2017 Victor Tebar: User can turn and move forward
 *  V0.07 19-Dic-2017 Nacho: Split into classes (all previous code goes to Game)
 *  V0.09 17-Ene-2018 Victor, Miguel Garcia, Miguel Pastor, Gonzalo: Use of the classes 
 *  RoomViewer and TextInterface.
 *  
 */

using System;

public class Game
{
    public enum orientations { NORTH, EAST, SOUTH, WEST };
    private RoomViewer rv = new RoomViewer();
    private TextInterface txt = new TextInterface();

    public void Run()
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
                    
                    int x = 0, y = 2; // Starting room
                    byte orientation = (byte)orientations.NORTH;
                    do
                    {
                        rv.Display(orientation,map,x,y);
                        txt.Display(map,x,y,orientation);

                    }
                    while (txt.GetCommand(map, ref x, ref y, ref orientation) != "end");
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


