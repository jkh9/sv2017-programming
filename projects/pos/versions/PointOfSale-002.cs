// 
// Point of sale
//

// Versions:
// V0.01 20-Sep-2017 LUCÍA NAVARRO VÉLEZ, Main menu
// V0.02 27-Sep-2017 Javier Herreros, Analyse user input

using System;
public class PointOfSale
{   
    public static void Main()
    {
        int option;
        Console.WriteLine("1-Sell");
        Console.WriteLine("2-Management");
        Console.WriteLine("0-Exit");
        Console.WriteLine();
        Console.WriteLine("Choose one option");
        option = Convert.ToInt32(Console.ReadLine());
        
        if (option == 1)
            Console.WriteLine("Soon");
        
        else if (option == 2)
            Console.WriteLine("Soon");
        
        else if (option == 0)
            Console.WriteLine("Bye!");
            
        else 
            Console.WriteLine("Wrong option");
    }
}
