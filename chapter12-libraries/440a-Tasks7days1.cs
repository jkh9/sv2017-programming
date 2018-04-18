// Javier Cases Sempere

using System;
using System.IO;

class Tasks7days
{
    static void Main(string[] args)
    {
         string[] month = 
         { 
             "Jan", "Feb", "Mar", "Apr", 
             "May", "Jun", "Jul", "Aug",
             "Sep", "Oct", "Nov", "Dec" 
        };
        
        StreamWriter writer = new StreamWriter("tasks.txt");
        DateTime d = DateTime.Now.AddDays(7);
        int currentYear = d.Year;
        do
        {
            writer.WriteLine(
                d.Day.ToString("00") + "-" + 
                month[d.Month - 1] + "-" + 
                d.Year % 100);
            d = d.AddDays(7);
        }
        while (d.Year == currentYear);
        writer.Close();
    }
}

