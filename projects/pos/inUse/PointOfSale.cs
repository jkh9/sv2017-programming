// 
// Point of sale
//

// Versions:
// V0.08 19-Dic-2017 Nacho: Split into classes, most content moved to SalesModule
// V0.13 20-Apr-2018 Nacho: Screen is cleared when entering. Title is displayed

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
        int option;

        do
        {
            ShowMenu();
            option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    SalesModule sales = new SalesModule();
                    sales.Run();
                    break;
                case 2:
                    AdminModule admin = new AdminModule();
                    admin.Run();
                    break;
                case 0:
                    Console.WriteLine("Bye!");
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("Wrong option");
                    Console.WriteLine();
                    break;
            }
        }
        while (option != 0);
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

