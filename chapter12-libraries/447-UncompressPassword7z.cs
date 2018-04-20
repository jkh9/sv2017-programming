// Ex.447: Create a program to find the password
// for the file "c.7z", knowing it is a 4 digit number

// Javier Saorín Vidal

using System;
using System.Diagnostics;

public class CompressTest
{
    public static void Main()
    {
        Console.Write("Enter the new file name: ");
        string fileName = Console.ReadLine();

        Process proc;

        string password = "";
        bool matchFound = false;
        int i = 0;
        do 
        {
            Console.Write(i+ " ");
            proc = Process.Start("7za.exe", "x " +
                fileName + " -p" + i.ToString("0000") + " -y");

            proc.WaitForExit();

            if (proc.ExitCode == 0)
            {
                matchFound = true;
                password = i.ToString("0000");
            }
            i++;
        }
        while ( i < 10000 && ! matchFound);

        if (matchFound)
            Console.WriteLine("The password is: " + password);
        else
            Console.WriteLine("Password not found...");
    } 
}
