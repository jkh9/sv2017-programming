// 
// DamMan
// Level: The game screen for a certain level of the game
//

// Versions:
// V0.01 13-Dic-2017 Nacho: Almost empty skeleton

using System;

public class Level
{
    // Associations

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
        Console.WriteLine("Level!");
    }
} /* end class Level */
