// Create a program to compress your C# source files, 
// calling the command line RAR archiver and asking
// the user for a password

// Version 2: using other paths

//Miguel García Gil
using System;
using System.Diagnostics;

public class Ex445
{
    public static void Main()
    {
        Console.Write("Name to compress? ");
        string name = Console.ReadLine();
        Console.Write("Password? ");
        string pass = Console.ReadLine();

        Process proc = Process.Start(
            "c:\\utils\\rar.exe",
            "a c:\\backup\\"+ name + ".rar c:\\data\\*.cs -r -p"+pass);
        proc.WaitForExit();
        
        if (proc.ExitCode == 0)
            Console.WriteLine("Successful");
        else
            Console.WriteLine("Errors found...");
    }
}
