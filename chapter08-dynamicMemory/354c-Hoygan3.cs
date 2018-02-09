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
        Hashtable myDictionary = new Hashtable();
        myDictionary.Add("hoygan", "oigan");
        myDictionary.Add("porfabor", "por favor");
        myDictionary.Add("nesecito", "necesito");
        myDictionary.Add("alluda", "ayuda");
        myDictionary.Add("grasias", "gracias");

        Console.Write("Enter a sentence: ");
        string text = Console.ReadLine();

        string[] parts = text.ToLower().Split();
        for (int i = 0; i < parts.Length; i++)
        {
            if (myDictionary.ContainsKey(parts[i]))
                parts[i] = (string) myDictionary[ parts[i] ];
        }

        Console.Write( String.Join(" ", parts)) ;
    }
}
