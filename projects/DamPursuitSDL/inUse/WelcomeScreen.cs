//Marcos Cervantes, Almudena López, Victor Tébar
//20/04/2018 Version 0.1 - Create class

using System;

class WelcomeScreen : Screen
{
    private Image welcome;

    public WelcomeScreen()
    {
        welcome = new Image("imgs/WelcomeScreen.png", 700, 410);
        welcome.MoveTo(50, 0);
    }

    public override void Display()
    {
        bool exit = false;
        do
        {
            Hardware.DrawImage(welcome);

            int keyPressed = Hardware.KeyPressed();

            if (keyPressed == Hardware.KEY_SPACE)
                exit = true;
            Hardware.UpdateScreen();
        }
        while (!exit);
    }
}
