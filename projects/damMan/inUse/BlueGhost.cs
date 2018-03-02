// 
// DamMan
// BlueGhost: The blue ghost
//

// Versions:
// V0.01 13-Dic-2017 Nacho: Almost empty skeleton
// V0.05 28-Feb-2018 Marcos, Jose, Moisés: More detailed skeleton

using System;

public class BlueGhost : Ghost
{
    public BlueGhost()
    {
        this.x = 6;
        this.y = 10;
    }

    public override void Display()
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write(ghost);
    }
} /* end class BlueGhost */

