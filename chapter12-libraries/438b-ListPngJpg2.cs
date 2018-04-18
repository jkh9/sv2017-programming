// Javier Saorín Vidal

using System;
using System.IO;

public class FileTest
{
    public static void Main()
    {
        string path = ".";
        string[] fileList = Directory.GetFiles(path);

        foreach (string fileName in fileList)
        {
            string extension = fileName.Substring(fileName.LastIndexOf('.')+1);
            if ( extension == "jpg" || extension == "png" )
            {
                Console.WriteLine(
                    fileName.Substring(fileName.LastIndexOf('\\') + 1));
            }
        }
    }
}