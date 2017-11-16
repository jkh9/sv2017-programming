// Simple example on how to dump to file an array of strings
// and how to retrieve it

using System;
using System.IO;

public class FilesAndStrings
{
    public static void Main()
    {
        // Checking if the file already exists
        if (File.Exists("example.txt"))
            Console.WriteLine("File found");
        else
            Console.WriteLine("File not found");
            
        // Let's write the data to a text file
        string[] sampleLines = { "This", "is an", "example" };
        File.WriteAllLines("example.txt", sampleLines);
        
        // Finally let's load it and show it
        string[] content = File.ReadAllLines("example.txt");
        foreach (string s in content)
            Console.WriteLine(s);
    }
}
