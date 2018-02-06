// Create an enhanced version of the previous 
// exercise (ArrayList of strings), adding the
// following options:
// 
// A to Add a new string
// 
// F to Find a string
// 
// I2 to Insert a new second string
// 
// D3 to Delete the third string
// 
// S to Sort the data
// 
// ? To Display all the data
// 
// Q to Quit

using System;
using System.Collections;

// ArrayList, many options. Interactive version
class ArrListManyOps1
{
    static void Main(string[] args)
    {
        ArrayList list = new ArrayList();
        string command;
        do
        {
            command = Console.ReadLine().ToUpper();
            if (command.Length > 0)
            {
                switch (command[0])
                {
                    case 'A':  // Add new data after existing data
                        Console.Write("Enter new data: ");
                        list.Add(Console.ReadLine());
                        break;

                    case 'F':  // Find data
                        Console.Write("Enter data to search for: ");
                        //if (list.Contains(Console.ReadLine()))
                        int pos = list.IndexOf(Console.ReadLine());
                        if (pos >= 0)
                            Console.WriteLine("Found! at pos {0}", pos+1);
                        else
                            Console.WriteLine("Not found!");
                        break;

                    case 'I':  // Insert new data
                        string insertPos = command.Substring(1);
                        Console.Write("Enter new data at pos {0}: ", insertPos);
                        list.Insert(
                            Convert.ToInt32(insertPos) -1,
                            Console.ReadLine());
                        break;

                    case 'D':  // Delete data
                        string deletePos = command.Substring(1);
                        Console.Write("Deleting data at pos {0}: ", deletePos);
                        list.RemoveAt(
                            Convert.ToInt32(deletePos) - 1);
                        Console.WriteLine("Deleted!");
                        break;

                    case 'S':  // Sort
                        Console.Write("Sorting... ");
                        list.Sort();
                        Console.WriteLine("Sorted!");
                        break;

                    case '?':  // Display all
                        Console.WriteLine("Data are:");
                        foreach (string t in list)
                            Console.WriteLine(t);
                        break;
                }
            }
        }
        while (command != "Q");
    }
}
