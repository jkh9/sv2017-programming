class Program
{
    static void Main(string[] args)
    {
        Hardware.Show(1024, 600, 24);
        GameScreen game = new GameScreen();
        game.Show();
    }
}

