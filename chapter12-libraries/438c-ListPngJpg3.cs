// Gonzalo Martinez

using System;
using System.IO;


public class Ex438
{
    public static void Main()
    {
        string dir = ".";
        string[] fileList = Directory.GetFiles(dir);
        foreach(string fileName in fileList)
        {
            if(fileName.ToLower().EndsWith(".png") ||
                fileName.ToLower().EndsWith(".jpg"))
                Console.WriteLine(fileName.Substring(2));
        }
    }
}


