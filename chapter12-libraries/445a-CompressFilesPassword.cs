// Create a program to compress your C# source files, 
// calling the command line RAR archiver and asking
// the user for a password

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
            "rar.exe","a "+ name + ".rar *.cs -r -p"+pass);
        proc.WaitForExit();
        
        if (proc.ExitCode == 0)
            Console.WriteLine("Successful");
        else
            Console.WriteLine("Errors found...");
    }
}
