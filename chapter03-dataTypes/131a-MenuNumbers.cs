using System;

public class Ex131
{
    public static void Main()
    {
        Console.WriteLine("1. Play");
        Console.WriteLine("2. Load");
        Console.WriteLine("0. Exit");
        
        int n = Convert.ToInt32(Console.ReadLine());
        
        switch (n)
        {
            case 1:
                Console.WriteLine("Playing...");
                break;
            case 2:
                Console.WriteLine("Loading...");
                break;
            case 0:
                Console.WriteLine("Exiting...");
                break;
            default:
                Console.WriteLine("???");
                break;
        }
        
    }
}
