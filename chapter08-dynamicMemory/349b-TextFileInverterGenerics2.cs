// Ex.349 - Text file inverter, generics
// Create a C# program to invert the contents of a text 
// file (and dump it to a new file), using a List<string>

//Miguel Puerta

using System.Collections.Generic;
using System.IO;

public class ex
{
    public static void Main()
    {
        Stack<string> myList = 
            new Stack<string>(
            File.ReadAllLines("fichero.txt"));
        File.WriteAllLines("fichero.txt", myList);
    }
}
