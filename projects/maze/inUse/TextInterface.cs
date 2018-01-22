/*
 *  Maze Game
 * 
 *  V0.07 19-Dic-2017 Nacho: Almost empty skeleton
 *  V0.09 17-Ene-2018 Victor, Miguel Garcia, Miguel Pastor, Gonzalo: Use of the methods of this class
 *  with the code from Game.
 */

using System;

public class TextInterface
{
    public void Display(string[,] map, int x, int y, byte orientation)
    {
        Console.Write("You are facing ");
        Console.WriteLine((Game.orientations)orientation);

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
        
    }

    public string GetCommand(string[,] map, ref int x, ref int y, ref byte orientation)
    {
        string answer = Console.ReadLine();
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
            if (orientation == (byte)Game.orientations.SOUTH &&
                map[y, x].Contains("D"))
                y++;
            else if (orientation == (byte)Game.orientations.WEST &&
                map[y, x].Contains("L"))
                x--;
            else if (orientation == (byte)Game.orientations.NORTH &&
                map[y, x].Contains("U"))
                y--;
            else if (orientation == (byte)Game.orientations.EAST &&
                map[y, x].Contains("R"))
                x++;
            else
                Console.WriteLine("You can't walk that way");
        }
        else
            Console.WriteLine("Unknown command");

        return answer;
    }

}

