//  Cesar Martin Sogorb

using System;
using System.Diagnostics;

public class RunProgram
{
    public static void Main()
    {
        Console.Write("Enter a filename: ");
        string fileName = Console.ReadLine();
        Process proc = Process.Start("notepad.exe", fileName);
        proc.WaitForExit();
    }
}
