/*
Create a simple "english to spanish" dictionary using a SortedList
*/

using System;
using System.Collections;

public class Ex344
{
    public static void Main()
    {
        SortedList myDictionary = new SortedList();
        myDictionary.Add("hello", "hola");
        myDictionary.Add("good bye", "adiós");
        myDictionary.Add("one", "uno");
        myDictionary.Add("two", "dos");

        string text;
        do
        {
            Console.Write("Enter a word: ");
            text = Console.ReadLine();
            if (text != "")
            {
                if (myDictionary.ContainsKey(text))
                    Console.WriteLine(myDictionary[text]);
                else
                    Console.WriteLine("Not found!");
            }
        }
        while (text != "");
    }
}
