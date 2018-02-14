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
        Dictionary<string, int> myDictionary =
            new Dictionary<string, int>();
        myDictionary.Add("Hello", 1);
        myDictionary.Add("Bye", 2);
        
        foreach( KeyValuePair<string, int> pair in myDictionary )
        {
            string key = pair.Key;
            int val = pair.Value;
            Console.WriteLine("{0} = {1}",
                key , val);
        }
    }
}
