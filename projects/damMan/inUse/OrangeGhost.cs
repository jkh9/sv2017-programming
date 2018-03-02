// 
// DamMan
// OrangeGhost: The orange ghost
//

// Versions:
// V0.01 13-Dic-2017 Nacho: Almost empty skeleton
// V0.05 28-Feb-2018 Marcos, Jose, Moisés: More detailed skeleton

using System;

public class OrangeGhost : Ghost
{
    public OrangeGhost()
    {
        this.x = 5;
        this.y = 20;
    }

    public override void Display()
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(ghost);
    }

} /* end class OrangeGhost */
