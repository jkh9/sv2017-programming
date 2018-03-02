// 
// DamMan
// RedGhost: The red ghost
//

// Versions:
// V0.01 13-Dic-2017 Nacho: Almost empty skeleton
// V0.05 28-Feb-2018 Marcos, Jose, Moisés: More detailed skeleton

using System;

public class RedGhost : Ghost
{
    public RedGhost()
    {
        this.x = 10;
        this.y = 5;
    }

    public override void Display()
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(ghost);
    }

} /* end class RedGhost */
