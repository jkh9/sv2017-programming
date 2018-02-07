/*
Read the data from a file as follows into a SortedList, 
to create a translator

hola=hello
uno=one
dos=two
*/

/*
 * Moisés Encinas Picazo
 */
using System;
using System.Collections;
using System.IO;

public class Ex347
{
    public static void Main()
    {
        SortedList myDictionary = new SortedList();

        string word;
        string[] data = File.ReadAllLines("data1.txt");

        for (int i = 0; i < data.Length; i++)
        {
            string[] parts = data[i].Split('=');
            myDictionary.Add(parts[0], parts[1]);
        }

        do
        {
            Console.Write("Word? ");
            word = Console.ReadLine();
            if (word != "")
            {
                if (myDictionary.ContainsKey(word))
                {
                    Console.WriteLine(myDictionary[word]);
                }
                else
                {
                    Console.WriteLine("Not found");
                }
            }
        } while (word != "");
    }
}
