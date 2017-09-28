// Asterisks (ex.046)

using System;
public class Asterisks
{
    public static void Main()
    {
        int asterisks = 0;
        
        // Ask the user for the starting data
        Console.Write("How many asterisks? ");
        asterisks = Convert.ToInt32(Console.ReadLine());
        
        // And let's repeat if needed
        while (asterisks > 0)
        {
            // Drawing several asterisks
            int i = 0;
            while (i < asterisks)
            {
                Console.Write("*");
                i = i+1;
            }
            // Proceeding to the next line
            Console.WriteLine();
            
            // And asking for data again
            Console.Write("How many asterisks? ");
            asterisks = Convert.ToInt32(Console.ReadLine());
        }
        
        Console.WriteLine("Bye!");
    }
}
