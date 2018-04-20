// Create a program to compress your C# source files, calling the
// command-line 7Za archiver and asking the user for a password. Also, the
// file name must include the date and time, in the format -20180419-163205

//Guillermo Pastor

using System;
using System.Diagnostics;

class Log
{
    static void Main(string[] args)
    {
        Console.Write("Compressed file name: ");
        fileName = Console.ReadLine();
        Console.WriteLine("Password:");
        pass = Console.ReadLine();
        proc = Process.Start("7za.exe", "a " + (fileName+"-"+
            DateTime.Now.ToString("yyyyMMdd-HHmmss") )+
            " *.cs -r -p" + pass);
        proc.WaitForExit();
        Console.WriteLine("Error: " + proc.ExitCode);
        Console.WriteLine("Compress process completed, press enter" +
            " to continue");
        Console.ReadLine();
    }
}
