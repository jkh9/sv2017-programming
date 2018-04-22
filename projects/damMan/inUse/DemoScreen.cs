// 
// DamMan
// DemoScreen: Shows a bit of the game... or it will do some day...
//

// Versions:
// V0.01 13-Dic-2017 Nacho: Almost empty skeleton
// V0.02 14-Dic-2017 Daniel y Cesar
// v0.03 20-Dic-2018 Angel Rebollo Berná: Created the whole game screen

using System;

public class DemoScreen
{

    private Ghost[] myGhosts = new Ghost[4];
    private Level myLevel;
    private Player myPlayer;

    public DemoScreen()
    {
        //Implementing the 4 type of ghost
        myGhosts[0] = new OrangeGhost();
        myGhosts[1] = new BlueGhost();
        myGhosts[2] = new RedGhost();
        myGhosts[3] = new PinkGhost();
        myPlayer = new Player();
        
        //Implementing the level
        myLevel = new Level(1);
    }

    public void Run()
    {
        bool exit = false;

        int x = 30, y = 0;
        int maxX = 75, minX = 30;
        int maxY = 0, minY = 25;
        int incrX = 1, incrY = 1;

        myLevel.Display();

        do
        {
            moveElements();
            drawElements();
            //moveDemo(ref x,ref y,maxX,maxY,minX,minY,incrX,incrY);
            pauseTillNextFrame();
            clearSprites();

            

            // And let's check if we must exit
            if (Console.KeyAvailable)
                if (Console.ReadKey(true).Key == ConsoleKey.Enter)
                    exit = true;
        }
        while (!exit);
    }

    // --- Animating enemies and other "self moving" objects -----
    public void moveElements()
    {
        //Move the 4 ghosts
        for (int i = 0; i < 4; i++)
        {
            myGhosts[i].Move(myLevel);
        }
    }

    public void moveDemo(ref int x, ref int y, int maxX,
        int maxY,int minX, int minY, int incrX, int incrY)
    {
        Console.SetCursorPosition(x, y);
        Console.Write("DEMO");

        y += incrY;
        if ((y == maxY) || (y == minY))
            incrY = -incrY;

        x += incrX;
        if ((x == maxX) || (x == minX))
            incrX *= -1;
    }


    // --- Drawing all the visible elements ---
    public void drawElements()
    {
        myPlayer.Display();
        //Draw the 4 ghosts
        for (int i = 0; i < 4; i++)
        {
            myGhosts[i].Display();
        }
    }


    // --- Pause afer each frame (20 ms, for a speed of 50 fps) -----
    public void pauseTillNextFrame()
    {
        System.Threading.Thread.Sleep(100);
    }

    //Clear of the sprites before writing them again
    public void clearSprites()
    {
        for (int i = 0; i < 4; i++)
        {
            myGhosts[i].ClearCharacter();
        }
    }

}
/* end class DemoScreen */
