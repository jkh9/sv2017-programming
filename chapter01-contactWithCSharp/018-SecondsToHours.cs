// Daniel Miquel Sirera
// Querubin Santana Sevilla
// Converting seconds to hours+minutes+seconds

using System;

public class SecondsFormat
{
    public static void Main()
    {
        int totalSeconds;
        int minutes;
        int hour;
        int seconds;

        Console.Write("Enter a quantity of seconds");
        totalSeconds = Convert.ToInt32(Console.ReadLine());
        
        hour = totalSeconds / 3600;
        minutes = (totalSeconds % 3600) / 60;
        seconds = (totalSeconds % 3600) % 60;
        
        Console.WriteLine("{0} seconds = {1} hours, {2} minutes, {3} seconds",
            seconds,hour,minutes,seconds);
    }
}
