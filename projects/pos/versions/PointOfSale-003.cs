// 
// Point of sale
//

// Versions:
// V0.01 20-Sep-2017 Lucía Navarro Vélez, Main menu
// V0.02 27-Sep-2017 Javier Herreros, Analyse user input
// V0.03 27-Sep-2017 Brandon Blasco, Main loop

using System;
public class PointOfSale
{   
    public static void Main()
    {
        int option;

        do
        {
            Console.WriteLine("1 - Sell");
            Console.WriteLine("2 - Management");
            Console.WriteLine("0 - Exit");
            Console.WriteLine();
        
            Console.WriteLine("Choose one option: ");
            option = Convert.ToInt32(Console.ReadLine());
            
            if (option == 1)
            {
                Console.WriteLine("Soon");
                Console.WriteLine();
            }
            else if (option == 2)
            {
                Console.WriteLine("Soon");
                Console.WriteLine();
            }
            else if (option == 0)
            {
                Console.WriteLine("Bye!");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Wrong option");
                Console.WriteLine();
            }
        }
        while (option != 0);
    }
}
