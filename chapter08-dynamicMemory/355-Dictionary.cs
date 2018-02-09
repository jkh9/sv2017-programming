/*
Create a C# program to translate from Hoygan to Spanish, 
using a Dictionary. It must work correctly with the 
following sentence:

hoygan porfabor nesecito alluda grasias
*/

//Raul Gogna

using System;
using System.Collections.Generic;

class Ex355
{
    static void Main(string[] args)
    {
        Dictionary<string, string> myDictionary = 
            new Dictionary<string, string>();
        myDictionary.Add("hoygan", "oigan");
        myDictionary.Add("porfabor", "por favor");
        myDictionary.Add("nesecito", "necesito");
        myDictionary.Add("alluda", "ayuda");
        myDictionary.Add("grasias", "gracias");
        string sentence;
        Console.WriteLine("Enter sentence: ");
        sentence = Console.ReadLine();
        string[] fragments = sentence.ToLower().Split();
        foreach (string parts in fragments)
        {
            if (myDictionary.ContainsKey(parts))
                Console.WriteLine(myDictionary[parts]);
            else
                Console.Write(parts + " ");
        }
    }
}
