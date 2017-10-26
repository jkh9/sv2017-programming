/*
Days in a month - Array

Create a C# program to ask the user for the number of a month (for 
example, 4 would mean April) and display the amount of days in that 
month (for example, 30 if the user chooses April) in a non-leap year.

You must NOT do it using "if" nor "switch", but an array of integers.

Example of run:

Enter month: 4
The month 4 has 30 days

Note: Final approach, correct
*/

using System;

public class DaysInMonth2
{
    public static void Main()
    {
        int[] days = {31,29,31,30,31,30,31,31,30,31,30,31};
        
        int month;
        
        Console.Write("Enter a number of month :");
        month = Convert.ToInt32( Console.ReadLine() ) - 1;
        
        Console.WriteLine("Number of day is {0}",days[month]);
    }
}
