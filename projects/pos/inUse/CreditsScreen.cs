// 
// Point of sale
//

// Versions:
// V0.08 19-Dic-2017 Nacho: Almost empty skeleton
// V0.14 20-Apr-2018 Guille, Brandon & Cases: Added a some style

using System;

class CreditsScreen
{
    public static void Display()
    {
        Console.Clear();
        string credits = "Credits soon available. Press Enter to continue...";
        Console.SetCursorPosition(Console.WindowWidth / 2 - (credits.Length / 2),
            Console.WindowHeight / 2);
        Console.Write(credits);
        Console.ReadLine();
    }
}
