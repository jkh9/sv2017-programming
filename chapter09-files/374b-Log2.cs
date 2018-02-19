// Logger (V2)

using System.IO;
using System;

public class Logs
{
    public static void Main()
    {
        StreamWriter myFile = new StreamWriter("logs.txt", true);
        Console.Write("Enter log: ");
        string line = Console.ReadLine();
        myFile.WriteLine(DateTime.Now + ": " + line);
        myFile.Close();
    }
}
