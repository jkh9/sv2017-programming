/*
 *  Maze Game
 * 
 *  V0.07 19-Dic-2017 Nacho: Main loop
 */

 public class Maze
{
    static void Main(string[] args)
    {
        WelcomeScreen w = new WelcomeScreen();
        w.Display();

        bool finished = false;
        do
        {
            MenuScreen menu = new MenuScreen();
            menu.Display();
            switch (menu.GetChosenOption())
            {
                case MenuScreen.PLAY:
                    Game g = new Game();
                    g.Run();
                    break;
                case MenuScreen.CREDITS:
                    CreditsScreen c = new CreditsScreen();
                    c.Display();
                    break;
                case MenuScreen.QUIT:
                    finished = true;
                    break;
            }
        }
        while (! finished);
    }
}
