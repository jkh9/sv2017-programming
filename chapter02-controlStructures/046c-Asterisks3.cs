// Asterisks
// Miguel Puerta

using System;
public class Asterisks
{
    public static void Main()
    {
        int asterisks = 0;
        
        Console.Write("How many asterisks? ");
        asterisks = Convert.ToInt32(Console.ReadLine());
        
        while (asterisks != 0)
        {
            Console.Write("*");
            asterisks = asterisks - 1;
            
            if (asterisks == 0)
            {
                Console.WriteLine();
                Console.Write("How many asterisks? ");
                asterisks = Convert.ToInt32(Console.ReadLine());
            }
        }        
        Console.WriteLine("Bye!");
    }
}
