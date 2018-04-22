// 
// DamMan
// Pause Menu : A Menu to Pause the Game
//

// Versions:
// V0.01 20-Abril-2018 Rebollo, Miguel Pastor, Martin-Montalvo, Pestana : Creation of Pause Class, 
//                     Added ESC to Exit Game, Added Space to Continue Game

using System;

namespace DamMan
{
    class Pause : Game
    {
        public void pause()
        {
            ConsoleKeyInfo key;

            do
            {
                key = Console.ReadKey(true);
            } while (Console.KeyAvailable);

            Console.Clear();
            string text = "->PRESS SPACE TO CONTINUE";
            Console.SetCursorPosition(40 - text.Length / 2, 12);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("PAUSE");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-> PRESS SPACE TO CONTINUE");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("-> PRESS ESC AGAIN TO EXIT");
            Console.ForegroundColor = ConsoleColor.White;

            if (key.Key == ConsoleKey.Escape)
            {
                DamMan.Game.gameFinished = true;
            }
            else if(key.Key == ConsoleKey.Spacebar)
            {
                DamMan.Game.myLevel.Display();
            }
        }
    }
}
