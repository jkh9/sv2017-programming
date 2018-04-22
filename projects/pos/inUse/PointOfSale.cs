// 
// Point of sale
//

// Versions:
// V0.08 19-Dic-2017 Nacho: Split into classes, most content moved to SalesModule
// V0.13 20-Apr-2018 Nacho: Screen is cleared when entering. Title is displayed
// V0.14 20-Apr-2018 Guille, Brandon & Cases: Minor Changes + Controlled Exception for Input

using System;

public class PointOfSale
{
    public static void Main(string[] args)
    {
        PointOfSale pos = new PointOfSale();
        pos.Run();
    }

    public void Run()
    {
        Int32 number;
        do
        {
            ShowMenu();
            bool cFormat = Int32.TryParse(Console.ReadLine(), out number);
            
            // Incorrect Format
            if (!cFormat)
                number = 10;

            switch (number)
            {
                case 1:
                    SalesModule sales = new SalesModule();
                    sales.Run();
                    break;
                case 2:
                    AdminModule admin = new AdminModule();
                    admin.Run();
                    break;
                case 3:
                    CreditsScreen.Display();
                    break;
                case 0:
                    Console.SetCursorPosition(Console.WindowWidth / 2 - 3,
                        Console.WindowHeight / 2);
                    Console.WriteLine("Bye");
                    break;
                default:
                    Console.WriteLine("Wrong option");
                    Console.WriteLine();
                    break;
            }
        }
        while (number != 0);
    }

    public void ShowMenu()
    {
        Console.SetWindowSize(80, 25);
        Console.Clear();
        Console.WriteLine("POINT OF SALE");
        Console.WriteLine();

        Console.WriteLine("1 - Sell");
        Console.WriteLine("2 - Management");
        Console.WriteLine("0 - Exit");
        Console.WriteLine();
        Console.Write("Choose an option: ");
    }
}

