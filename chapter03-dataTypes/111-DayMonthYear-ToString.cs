// Ask the user for a day, a month and a year 
// and display them properly using two or four 
// digits as needed.

// V2: Using ToString

using System;

public class DayMonthYear2
{
    public static void Main()
    {
        byte day, month;
        ushort year;
        
        Console.Write("Enter day: ");
        day = Convert.ToByte(Console.ReadLine());
        
        Console.Write("Enter month: ");
        month = Convert.ToByte(Console.ReadLine());
        
        Console.Write("Enter year: ");
        year = Convert.ToUInt16(Console.ReadLine());
        
        Console.Write("{0}/",day.ToString("00"));
        Console.Write("{0}/",month.ToString("00"));
        Console.WriteLine(year.ToString("0000"));
    }
}

