// Ex.369 - Comparing two lists of words
//
// Create a program to calculate how many different words are there 
// in the files words.txt and words2.txt
//
// Version 3: Using a Hashtable

using System;
using System.IO;
using System.Text;
using System.Collections;

public class Ex369c
{
    public static void Main()
    {
        Hashtable list1 = new Hashtable(500000);
        Hashtable list2 = new Hashtable(300000);
        int cont = 0;

        //Add numbers1 
        Console.WriteLine("Reading file 1");
        StreamReader words = new StreamReader("words.txt");
        string line;
        do
        {
            line = words.ReadLine();
            if (line != null)
            {
                if (!list1.Contains(line))
                    list1.Add(line, true);
            }

        } while (line != null);
        words.Close();

        //Add numbers2
        Console.WriteLine("Reading file 2");
        StreamReader words2 = new StreamReader("words2.txt");
        do
        {
            line = words2.ReadLine();
            if (line != null)
            {
                if (!list2.Contains(line))
                    list2.Add(line, true);
            }

        } while (line != null);
        words2.Close();

        Console.WriteLine("Analyzing... ");
        DateTime start = DateTime.Now;

        // Search in list2 the words of list1
        foreach (string s in list1.Keys)
        {
            if (!list2.Contains(s))
            {
                cont++;
                if (cont % 1000 == 0)
                {
                    Console.WriteLine(cont);
                }
            }
        }

        Console.WriteLine(DateTime.Now - start);
        Console.WriteLine(cont);
        Console.ReadLine();
    }
}
