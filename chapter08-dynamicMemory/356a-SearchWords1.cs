// Ex.356 - Search in list of words
// Create a C# program to allow the user searching words 
// in the file "words.txt"

//Raul Gogna

using System;
using System.Collections.Generic;
using System.IO;
class Ex356
{
    static void Main(string[] args)
    {
        List<string> myDictionary = 
            new List<string>();
        string word;
        string[] data = File.ReadAllLines("words.txt");
        bool found;
        for (int i = 0; i < data.Length; i++)
        {
            myDictionary.Add(data[i]);
        }
        do
        {
            Console.Write("What word do you want to translate: ");
            word = Console.ReadLine();
            if (word != "")
            {
                if (myDictionary.Contains(word))
                    found = true;
                else
                    found = false;

                Console.WriteLine(found);
            }
        } while (word != "");
    }
}
