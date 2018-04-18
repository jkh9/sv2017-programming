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
        myFile.WriteLine(
            date.ToString("yyyy-MM-dd HH:mm:ss.fff -")
            + line);

        myFile.Close();
    }
}
