//Pedro Luis Coloma

using System;
using System.IO;

public class DateLog
{
    public static void Main(string[] args)
    {
        StreamWriter myFile = File.AppendText("log.txt");
        DateTime date = DateTime.Now;
        string line ="";
        for (int i = 0; i < args.Length; i++)
        {
            line += " ";
            line += args[i];
        }
        myFile.WriteLine(date.Year + "-" + 
            date.Month.ToString("00") + "-" + 
            date.Day.ToString("00") +" "+
            date.Hour.ToString("00") +":"+ 
            date.Minute.ToString("00") +":"+ 
            date.Second.ToString("00") + "."+
            date.Millisecond.ToString("000") + " -"+ 
            line);

        myFile.Close();
    }
}
