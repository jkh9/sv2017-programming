// Parking, first approach (paid by hours)

using System;

public class Parking
{
    public static void Main()
    {
        const double PRICE_POR_HOUR = 2;
        
        Console.Write("Enter the start hour: ");
        int hour1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the start minute: ");
        int minute1 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter the exit hour: ");
        int hour2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the exit minute: ");
        int minute2 = Convert.ToInt32(Console.ReadLine());
        
        if (hour2 < hour1)  // Exit after midnight?
            hour2 += 24;
            
        int totalMinutes = (hour2-hour1) * 60
            + minute2 - minute1;
            
        int fullHours = totalMinutes / 60;
        if (totalMinutes % 60 != 0)
            fullHours ++;
        
        Console.WriteLine("You have to pay: "+
            fullHours * PRICE_POR_HOUR);
    }
}
