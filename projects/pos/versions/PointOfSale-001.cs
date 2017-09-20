// LUCÍA NAVARRO VÉLEZ
// Point of sale

// Versions:
// V0.01 20-Sep-2017 Main menu

using System;
public class PointOfSale
{   
    public static void Main()
    {
        int option;
        Console.WriteLine("1-Sell");
        Console.WriteLine("2-Management");
        Console.WriteLine("3-Exit");
        Console.WriteLine("");
        Console.WriteLine("Choose one option");
        option = Convert.ToInt32(Console.ReadLine());
    }
}
