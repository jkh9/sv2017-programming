// Logger

using System.IO;
using System;

public class Logs
{
    public static void Main()
    {
        StreamWriter myFile = File.AppendText("logs.txt");
        Console.Write("Enter log: ");
        string line = Console.ReadLine();
        myFile.WriteLine(DateTime.Now + ": " + line);
        myFile.Close();
    }
}
