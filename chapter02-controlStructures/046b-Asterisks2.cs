// Asterisks
// Almudena López Sánchez

using System;
public class Asterisks
{
    public static void Main()
    {
        int asterisks = 1;
        int count;
        
        while (asterisks > 0)
        {
            Console.Write("How many asterisks? ");
            asterisks = Convert.ToInt32(Console.ReadLine());
            
            if (asterisks == 0)
                Console.WriteLine("Bye!");
            else
            {
                count = asterisks;
                while (count > 0)
                {
                    Console.Write("*");
                    count = count - 1;
                }
                Console.WriteLine();
            }
        }        
    }
}
