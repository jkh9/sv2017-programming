// Miguel García Gil
// Seconds alive

using System;
using System.IO;

public class SecondsAlive
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Day of birth?");
        int day = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Month of birth?");
        int month = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Year of birth?");
        int year = Convert.ToInt32(Console.ReadLine());

        DateTime today = DateTime.Today;
        DateTime birthDate = new DateTime(year, month, day);

        TimeSpan diff = today.Subtract(birthDate);
        Console.WriteLine("Approx {0} seconds elapsed",diff.TotalSeconds);
    }
}
