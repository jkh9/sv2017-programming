// Ex.369 - Comparing two lists of words
//
// Create a program to calculate how many different words are there 
// in the files words.txt and words2.txt
//
// Version 2: Using a SortedList

using System;
using System.IO;
using System.Text;
using System.Collections;

public class Ex369b
{
    public static void Main()
    {
        SortedList list1 = new SortedList();
        SortedList list2 = new SortedList();
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
