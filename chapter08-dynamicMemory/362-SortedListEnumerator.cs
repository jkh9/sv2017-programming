using System;
using System.Collections;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        SortedList myDictionary = new SortedList();
        myDictionary.Add("hello", "hola");
        myDictionary.Add("good bye", "adiós");
        myDictionary.Add("one", "uno");
        myDictionary.Add("two", "dos");
        myDictionary.Add("and", "y");
        
        IDictionaryEnumerator miEnumerador = 
            myDictionary.GetEnumerator();
        while (miEnumerador.MoveNext())
            Console.WriteLine("{0} = {1}",
                miEnumerador.Key,miEnumerador.Value);
    }
}
