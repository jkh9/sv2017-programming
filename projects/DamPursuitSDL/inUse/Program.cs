//Marcos Cervantes, Almudena López, Victor Tébar
//20/04/2018 Version 0.1 - Add WelcomeScreen

class Program
{
    static void Main(string[] args)
    {
        Hardware.Show(1024, 600, 24);
        WelcomeScreen welcomeScreen = new WelcomeScreen();
        GameScreen game = new GameScreen();

        welcomeScreen.Display();
        game.Show();
    }
}
