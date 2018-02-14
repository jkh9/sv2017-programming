/*
 * Create a new version of the exercise 321 (Hashtable + Enumerator), using a Dictionary
 * Raul Gogna
 */
using System;
using System.Collections.Generic;
using System.Collections;

class Ex363
{
    static void Main(string[] args)
    {
        Dictionary<string, string> myDictionary =
            new Dictionary<string, string>();
        myDictionary.Add("Hello", "Hola");
        myDictionary.Add("Bye", "Adios");
        myDictionary.Add("Car", "Coche");
        myDictionary.Add("Year", "Año");
        myDictionary.Add("Old", "Edad");

        IDictionaryEnumerator dictionary = myDictionary.GetEnumerator();
        while (dictionary.MoveNext())
            Console.WriteLine("{0} = {1}",
                dictionary.Key, dictionary.Value);
    }
}
