// Guillermo Pastor Pastor
using System;
using System.Collections;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Hashtable myDictionary = new Hashtable();
        myDictionary.Add("hello", "hola");
        myDictionary.Add("good bye", "adiós");
        myDictionary.Add("one", "uno");
        myDictionary.Add("two", "dos");
        myDictionary.Add("and", "y");
        myDictionary.Add("extra", "extra");
        
        IDictionaryEnumerator miEnumerador = 
            myDictionary.GetEnumerator();
        while (miEnumerador.MoveNext())
            Console.WriteLine("{0} = {1}",
                miEnumerador.Key,miEnumerador.Value);
    }
}
