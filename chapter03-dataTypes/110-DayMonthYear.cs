// Ask the user for a day, a month and a year 
// and display them properly using two or four 
// digits as needed.

// Marcos Cervantes

using System;

public class DayMonthYear
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
        
        if (day < 10)
            Console.Write("0");         
        Console.Write("{0}/",day);
        
        if (month < 10)
            Console.Write("0");
        Console.Write("{0}/",month);
        
        if (year < 1000)
            Console.Write("000");
        else if (year < 100)
            Console.Write("00");
        else if (year < 10)
            Console.Write("0");
        Console.WriteLine(year);
    }
}

