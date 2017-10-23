using System;

public class Ex131
{
    public static void Main()
    {
        const int PLAY = 1;
        const int LOAD = 2;
        const int EXIT = 0;
        
        Console.WriteLine("1. Play");
        Console.WriteLine("2. Load");
        Console.WriteLine("0. Exit");
        
        int n = Convert.ToInt32(Console.ReadLine());
        
        switch (n)
        {
            case PLAY:
                Console.WriteLine("Playing...");
                break;
            case LOAD:
                Console.WriteLine("Loading...");
                break;
            case EXIT:
                Console.WriteLine("Exiting...");
                break;
            default:
                Console.WriteLine("???");
                break;
        }
        
    }
}
