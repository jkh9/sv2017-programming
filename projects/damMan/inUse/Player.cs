// 
// DamMan
// Player: PacMan, used by the player  
//

// Versions:
// V0.01 13-Dic-2017 Nacho: Almost empty skeleton
// V0.03 07-Ene-2018 Nacho: Player can move right
// v0.04 17-Ene-2018 Luis Sellés, Brandon Blasco, César Martinez, Tania Pigem:
//            Player can move in four directions
// V0.05 28-Feb-2018 Marcos, Jose, Moisés: Added Display and ClearCharacter

using System;

public class Player : Sprite
{
    // Associations
    protected char character = 'o';

    // public Game  myGame;

    // Operations

    public void MoveRight()
    {
        x++;
    }

    public void MoveLeft()
    {
        x--;
    }

    public void MoveUp()
    {
        y--;
    }

    public void MoveDown()
    {
        y++;
    }

    public override void Display()
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write(character);

    }
    public override void ClearCharacter()
    {
        Console.SetCursorPosition(GetX(), GetY());
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Write(character);
    }
} /* end class Player */