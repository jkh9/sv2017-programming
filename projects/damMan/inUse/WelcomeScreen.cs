// 
// DamMan
// WelcomeScreen: First thing to display
//

// Versions:
// V0.01 13-Dic-2017 Nacho: Almost empty skeleton
// V0.02 14-Dic-2017 López, Pastor, Puerta: variables
//  and FunctionRun()
// V0.03 07-Ene-2018 Nacho: Text "Game" instead of "Exit"

using System;

public class WelcomeScreen
{
    private DemoScreen myDemoScreen;
    private HiScoresScreen myHiScoresScreen;
    private CreditsScreen myCreditsScreen;
    protected bool exit = false;

    public void Run()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        string text = "Welcome To DamMan!";
        Console.SetCursorPosition(40 - text.Length / 2, 12);
        Console.WriteLine(text);
        Console.ReadKey();
        Console.Clear();

        do
        {
            Console.SetCursorPosition(40, 12);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("D. Demo");
            Console.SetCursorPosition(40, 13);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("H. HighScore");
            Console.SetCursorPosition(40, 14);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("C. Credits");
            Console.SetCursorPosition(40, 15);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("G. Game");
            Console.ResetColor();
            char option = Convert.ToChar(Console.ReadLine().ToLower());

            switch (option)
            {
                case 'd':
                    Console.Clear();
                    myDemoScreen = new DemoScreen();
                    myDemoScreen.Run();
                    Console.Clear();
                    break;
                case 'h':
                    Console.Clear();
                    myHiScoresScreen = new HiScoresScreen();
                    myHiScoresScreen.Run();
                    Console.Clear();
                    break;
                case 'c':
                    Console.Clear();
                    myCreditsScreen = new CreditsScreen();
                    myCreditsScreen.Run();
                    Console.Clear();
                    break;
                case 'g':
                    Console.Clear();
                    Console.SetCursorPosition(40, 15);
                    Console.ForegroundColor = ConsoleColor.Red;
                    //Console.WriteLine("Bye!");
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Wrong Option!");
                    break;
            }
        }
        while (!exit);
    }
}
