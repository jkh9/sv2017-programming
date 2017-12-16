// 
// DamMan
// DemoScreen: Shows a bit of the game... or it will do some day...
//

// Versions:
// V0.01 13-Dic-2017 Nacho: Almost empty skeleton
// V0.02 14-Dic-2017 Daniel y Cesar

using System;

public class DemoScreen
{

    public void Run()
    {
        Console.WriteLine("Demo!");
        Console.ReadLine();
        int cont = 0;
        for (int i = 0; i < 40; i++)
        {
            Console.SetCursorPosition(cont, 12);
            Console.Write("K o");
            Console.Clear();
            Console.Write("| o");
            Console.Clear();
            cont++;
        }
    }

}
/* end class DemoScreen */
