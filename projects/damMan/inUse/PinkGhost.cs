// 
// DamMan
// PinkGhost: The pink ghost
//

// Versions:
// V0.01 13-Dic-2017 Nacho: Almost empty skeleton
// V0.05 28-Feb-2018 Marcos, Jose, Moisés: More detailed skeleton

using System;

public class PinkGhost : Ghost
{
    public PinkGhost()
    {
        this.x = 3;
        this.y = 5;
    }

    public override void Display()
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write(ghost);
    }
} /* end class PinkGhost */
