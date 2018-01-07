// 
// DamMan
// Level: The game screen for a certain level of the game
//

// Versions:
// V0.01 13-Dic-2017 Nacho: Almost empty skeleton
// V0.03 07-Ene-2018 Nacho: Example on how to draw the data of the level

using System;

public class Level
{
    // Associations
    string[] mapData =
    {
        "+------------++------------+",
        "|............||............|",
        "|.+--+.+---+.||.+---+.+--+.|",
        "|o|  |.|   |.||.|   |.|  |o|",
        "|.+--+.+---+.++.+---+.+--+.|",
        "|..........................|",
    };

    // public Game  myGame;

    // Operations

    public  bool CanMoveTo(int newX, int newY)
    {
        return true;
    }

    public  bool IsFinished()
    {
        return false;
    }

    public  void Display()
    {
        foreach (string line in mapData)
        {
            foreach(char c in line)
            {
                if (c == '.')
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else if (c == 'o')
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
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
