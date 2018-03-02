// 
// DamMan
// Level: The game screen for a certain level of the game
//

// Versions:
// V0.01 13-Dic-2017 Nacho: Almost empty skeleton
// V0.03 07-Ene-2018 Nacho: Example on how to draw the data of the level
// v0.04 17-Ene-2018 Luis Sellés, Brandon Blasco, César Martinez, Tania Pigem:
//            More detailed background
// V0.05 28-Feb-2018 Marcos, Jose, Moisés: Added CanMoveTo
// V0.06 28-Feb-2018 Brandon Blasco, Cesar Martin, Luis Selles - Corrections by Nacho:
//         Loading a level from a TXT file

using System;
using System.IO;

public class Level
{
    // Associations
    string[] mapData;

    // Constructor
    public Level(int number)
    {
        mapData = File.ReadAllLines("levels/level" + 
            number.ToString("000") + ".txt");
    }

    // Operations

    //Checking if we can move
    public bool CanMoveTo(int newX, int newY)
    {
        return !(mapData[newY][newX] == '|' || mapData[newY][newX] == '+' ||
            mapData[newY][newX] == '-');
    }

    public bool IsFinished()
    {
        return false;
    }

    public void Display()
    {
        Console.SetCursorPosition(0, 0);
        foreach (string line in mapData)
        {
            foreach (char c in line)
            {
                if (c == '.')
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (c == 'o')
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                Console.Write(c);
            }
            Console.WriteLine();
        }
        // Console.WriteLine("Level!");
    }
} /* end class Level */
