// Ex.356 - Search in list of words
// Create a C# program to allow the user searching words 
// in the file "words.txt"

//Gonzalo Martinez

using System;
using System.Collections.Generic;
using System.IO;

public class DictionaryWords
{
    public static void Main()
    {
        Dictionary<string, int> myDictionary = 
            new Dictionary<string, int>();
        
        string[] data = File.ReadAllLines("words.txt");
        
        for(int i = 0; i < data.Length; i++)
        {
            if(!myDictionary.ContainsKey(data[i]))
                myDictionary.Add(data[i], i + 1);
        }
        
        Console.Write("Enter a word: ");
        string text = Console.ReadLine();
        
        if(myDictionary.ContainsKey(text))
            Console.WriteLine("Found at position {0}!", myDictionary[text]);
        else
            Console.WriteLine("Word doesn't exist!");
    }
}
