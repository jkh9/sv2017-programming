/*
Create a program to display the calendar (in console) for a certain month and a 
certain year. For example, if the user enters the year 2017 and the month 9, 
the result should be:

   September 2017
mo tu we th fr sa su
             1  2  3
 4  5  6  7  8  9 10
11 12 13 14 15 16 17
18 19 20 21 22 23 24
25 26 27 28
*/

using System;

//by Renata Pestana Ribeiro

class Calendar
{
    public static int DaysInMonth(int month)
    {
        int dias=30;
        if (month == 2)  // Should check if it is a leap year
            dias = 31;
        else if (month == 1 || month == 3 || month == 5 || month == 7 
                || month == 8 || month == 10 || month == 12 )
            dias = 31;
        return dias;
    }
    
    static void Main(string[] args)
    {
        Console.Write("Enter the year: ");
        int year = int.Parse(Console.ReadLine());
        Console.Write("Enter the month: ");
        int month = int.Parse(Console.ReadLine());
        
        DateTime startDate = new DateTime(year, month, 1);
        
        // Header
        string header = startDate.ToString("MMMM") + " " + year;
        int size = (20 - header.Length)/2;
        for (int i = 0; i < size; i++)
            Console.Write(" ");
        Console.WriteLine(header);
        Console.WriteLine("Mo Tu We Th Fr Sa Su");

        int currentDay = (int) startDate.DayOfWeek;
        
        if (currentDay == 0) // Sunday should be the last, not the first
            currentDay = 7;
        
        for (int i = 0; i < currentDay-1; i++) // Leading spaces, first line
            Console.Write("   ");
        
        for (int i = 1; i <= DaysInMonth(month); i++)
        {
            if (i < 10)
                Console.Write(" " + i);
            else
                Console.Write(i);
                
            Console.Write(" ");
            currentDay++;
            if (currentDay > 7)
            {
                Console.WriteLine();
                currentDay = 1;
            }
        }
    }
}
