// Create a program to compress your C# source files, 
// calling the command line RAR archiver

// Gonzalo Martinez

using System;
using System.Diagnostics;

public class Ex444
{
    public static void Main()
    {
        Console.Write("Enter the backup file name: ");
        string name = Console.ReadLine();
        
        Process proc = Process.Start(
            "rar.exe", "a " + name + " *.cs -r");
        proc.WaitForExit();
    }
}
