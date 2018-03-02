// 
// DamMan
// Ghost: The base for the 4 ghosts
//

// Versions:
// V0.01 13-Dic-2017 Nacho: Almost empty skeleton
// v0.04 17-Ene-2018 Luis Sellés, Brandon Blasco, César Martinez, Tania Pigem:
//            Methods MoveRight, Left, Up, Down (almost empty)
// V0.05 28-Feb-2018 Marcos, Jose, Moisés: Added method "Move"

using System;

public class Ghost : Sprite
{
    // Associations
    public bool Pasive { get; set; }
    protected char ghost { get; } = 'n';

    // public Game  myGame;

    // Operations
    private void MoveRight()
    {
        x++;
    }

    private void MoveLeft()
    {
        x--;
    }

    private void MoveUp()
    {
        y--;
    }

    private void MoveDown()
    {
        y++;
    }

    public void Move(Level level)
    {
        System.Random r = new System.Random();
        int movement = r.Next(1, 5);
        switch (movement)
        {
            case 1:
                if (level.CanMoveTo(x + 1, y))
                    MoveRight();
                break;
            case 2:
                if (level.CanMoveTo(x - 1, y))
                    MoveLeft();
                break;
            case 3:
                if (level.CanMoveTo(x, y - 1))
                    MoveUp();
                break;
            case 4:
                if (level.CanMoveTo(x, y + 1))
                    MoveDown();
                break;
            default:
                break;
        }
    }

    public override void ClearCharacter()
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Write(ghost);
    }
}
/* end class Ghost */
