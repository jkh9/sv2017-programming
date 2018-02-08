/*
Create a simple "english to spanish" dictionary using a Hashtable
*/

using System;
using System.Collections;

public class Ex345
{
    public static void Main()
    {
        Hashtable myDictionary = new Hashtable();
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
