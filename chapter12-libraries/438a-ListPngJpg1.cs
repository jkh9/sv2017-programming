// Luis Selles

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

public class Excercise
{
    public static void Main()
    {
        string dir = ".";
        List<string> totalFiles = new List<string>();

        string[] fileList = Directory.GetFiles(dir,"*.png");

        foreach (string fileName in fileList)
            totalFiles.Add(fileName);

        fileList = Directory.GetFiles(dir, "*.jpg");

        foreach (string fileName in fileList)
            totalFiles.Add(fileName);

        foreach (string fileName in totalFiles)
            Console.WriteLine(fileName.Substring(fileName.LastIndexOf("\\")+1));
    }
