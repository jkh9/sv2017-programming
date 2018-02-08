// Ex.350 - Removing duplicated lines

// Create a C# program to sort the contents of a text file
// and dump it to a new file, removing the duplicated lines

// Raúl Gogna

using System;
using System.Collections.Generic;
using System.IO;

class Ex350
{
    static void Main(string[] args)
    {
        List<string> myList = new List<string>(
            File.ReadAllLines("data1.txt"));
        myList.Sort();
        for (int i = 0; i < myList.Count - 1; i++)
        {
            Console.WriteLine("Checking: " + myList[i]);
            if (myList[i] == myList[i+1])
            {
                myList.RemoveAt(i);
                Console.WriteLine("Removed!");
                i--;  // To check again the same position
            }
            
        }
        File.WriteAllLines("data2.txt", myList.ToArray());
    }
}
