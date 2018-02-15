// Ex.369 - Comparing two lists of words
//
// Create a program to calculate how many different words are there 
// in the files words.txt and words2.txt
//
// Version 1: Using a List

// Moisés Encinas Picazo

using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

public class Ex369
{
    public static void Main()
    {
        List<string> list1 = new List<string>();
        List<string> list2 = new List<string>();
        int cont = 0;

        //Add numbers1 
        StreamReader words = new StreamReader("words.txt");
        string line;
        do
        {
            line = words.ReadLine();
            if (line != null)
            {
                list1.Add(line);
            }

        } while (line != null);
        words.Close();

        //Add numbers2
        StreamReader words2 = new StreamReader("words2.txt");
        do
        {
            line = words2.ReadLine();
            if (line != null)
            {
                list2.Add(line);
            }

        } while (line != null);
        words2.Close();
        
        DateTime start = DateTime.Now;

        // Search in list2 the words of list1
        for (int i = 0; i < list1.Count; i++)
        {
            if (! list2.Contains(list1[i]))
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
    }
}
