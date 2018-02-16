/*
Display the words in the file "textFile2.txt" 
which start with an "a"
*/
using System;
using System.IO;

public class ReadingAFile1
{
    public static void Main()
    {
        StreamReader myFile = new StreamReader("words.txt");
        string line;
        do 
        {
            line = myFile.ReadLine();
            if (line != null)
            {
                if ((line.Length > 0) && (line[0] == 'a'))
                    Console.Write( line + " ");
            }
        } 
        while (line != null);
        Console.WriteLine();

        myFile.Close();
    }
}
