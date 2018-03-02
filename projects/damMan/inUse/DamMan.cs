// 
// DamMan
// Main class
//

// Versions:
// V0.01 13-Dic-2017 Nacho: Almost empty skeleton
// V0.05 28-Feb-2018 Marcos, Jose, Moisés: Cursor Hidden

using System;

public class DamMan
{
    // Attributes

    private int maxScore;
    private Game myGame;
    private WelcomeScreen myWelcomeScreen;

    // Operations

    public void Run()
    {
        while (true) //  ;-)
        {
            myWelcomeScreen = new WelcomeScreen();
            myWelcomeScreen.Run();

            myGame = new Game();
            myGame.Run();
        }
    }

    static void Main(string[] args)
    {
        Console.CursorVisible = false;
        DamMan myPacman = new DamMan();
        myPacman.Run();
    }
} /* end class DamMan */ 
