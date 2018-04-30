/*
Create a program to display the names of the files contained in the 
current directory and its subdirectories which follow a certain 
wildcard (for example, "*.cs"). 
*/

using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string filter = args.Length < 1 ? "*.*" : args[0];
        string currentDir = Directory.GetCurrentDirectory();
        ShowContent(currentDir, filter);
    }

    public static void ShowContent( string dir, string filter)
    {
        Console.WriteLine(dir);
        String[] files = Directory.GetFiles(dir, filter);
        foreach (string f in files)
        {
            Console.WriteLine("  "+f);
        }

        String[] paths = Directory.GetDirectories(dir, filter);
        foreach( string f in paths)
        {
            ShowContent(f, filter);
        }
        
        

    }
}

