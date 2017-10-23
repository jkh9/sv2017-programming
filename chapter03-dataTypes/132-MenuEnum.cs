using System;

public class Ex131
{
    enum options { EXIT, PLAY, LOAD };
    
    public static void Main()
    {
        Console.WriteLine("1. Play");
        Console.WriteLine("2. Load");
        Console.WriteLine("0. Exit");
        
        int n = Convert.ToInt32(Console.ReadLine());
        
        switch (n)
        {
            case (int) options.PLAY:
                Console.WriteLine("Playing...");
                break;
            case (int) options.LOAD:
                Console.WriteLine("Loading...");
                break;
            case (int) options.EXIT:
                Console.WriteLine("Exiting...");
                break;
            default:
                Console.WriteLine("???");
                break;
        }
        
    }
}
