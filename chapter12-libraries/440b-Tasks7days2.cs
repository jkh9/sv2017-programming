// Javier Cases Sempere

using System;
using System.IO;

class Tasks7days
{
    static void Main(string[] args)
    {
        StreamWriter writer = new StreamWriter("tasks.txt");
        DateTime d = DateTime.Now.AddDays(7);
        int currentYear = d.Year;
        do
        {
            string month = d.ToString("MMM").Substring(0, 1).ToUpper() 
                + d.ToString("MMM").Substring(1, 2);
            writer.WriteLine(d.Day + " - " + month + " - " + d.Year);
            d = d.AddDays(7);
        }
        while (d.Year == currentYear);
        writer.Close();
    }
}
