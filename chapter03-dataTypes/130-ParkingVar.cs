// Parking, first approach (paid by hours)

using System;

public class Parking
{
    public static void Main()
    {
        const double PRICE_POR_HOUR = 2;
        
        Console.Write("Enter the start hour: ");
        var hour1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the start minute: ");
        var minute1 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter the exit hour: ");
        var hour2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the exit minute: ");
        var minute2 = Convert.ToInt32(Console.ReadLine());
        
        if (hour2 < hour1)  // Exit after midnight?
            hour2 += 24;
            
        var totalMinutes = (hour2-hour1) * 60
            + minute2 - minute1;
            
        int fullHours = totalMinutes / 60;
        if (totalMinutes % 60 != 0)
            fullHours ++;
        
        var price = fullHours * PRICE_POR_HOUR;
        
        Console.WriteLine("You have to pay: " + price);
    }
}
