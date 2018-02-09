/*
Create a C# program to translate from Hoygan to Spanish, 
using a SortedList. It must work correctly with the following sentence:

hoygan porfabor nesecito alluda grasias
*/

using System;
using System.Collections;

public class Hoygan
{
    public static void Main()
    {
        SortedList myDictionary = new SortedList();
        myDictionary.Add("hoygan", "oigan");
        myDictionary.Add("porfabor", "por favor");
        myDictionary.Add("nesecito", "necesito");
        myDictionary.Add("alluda", "ayuda");
        myDictionary.Add("grasias", "gracias");

        Console.Write("Enter a sentence: ");
        string text = Console.ReadLine();

        string[] parts = text.ToLower().Split();

        foreach (string part in parts)
        {
            if (myDictionary.ContainsKey(part))
                Console.Write(myDictionary[part] + " ");
            else
                Console.Write(part + " ");
        }
    }
}
