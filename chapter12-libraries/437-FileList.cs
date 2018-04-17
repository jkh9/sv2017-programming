// Gonzalo Martinez

using System;
using System.IO;

public class Ex437
{
    public static void Main()
    {
        string dir = ".";
        string[] fileList = Directory.GetFiles(dir);
        foreach(string fileName in fileList)
            Console.WriteLine(fileName);
    }
}

