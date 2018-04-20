// Create a program to compress your C# source files, calling the
// command-line 7Za archiver and asking the user for a password. Also, the
// file name must include the date and time, in the format -20180419-163205

using System;
using System.Diagnostics;

public class Ex
{
    public static void Main()
    {
        Console.Write("Enter backup file name: ");
        string name = Console.ReadLine() + "-" +
               DateTime.Now.Year.ToString("0000") + 
               DateTime.Now.Month.ToString("00") +
               DateTime.Now.Day.ToString("00") + "-" +
               DateTime.Now.Hour.ToString("00") + 
               DateTime.Now.Minute.ToString("00") +
               DateTime.Now.Second.ToString("00");

        Console.Write("Password: ");
        string pass = Console.ReadLine();
        
        Process proc = Process.Start(
            "7za.exe", "a " + name + " *.cs -r -p"+pass);
        proc.WaitForExit();

        if(proc.ExitCode == 0)
            Console.WriteLine("Successful");
        else
            Console.WriteLine("An error has ocurred");
    }
}
