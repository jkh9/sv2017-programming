// Ex.349 - Text file inverter, generics
// Create a C# program to invert the contents of a text 
// file (and dump it to a new file), using a List<string>

// Francisco Sabater Villora

using System.Collections.Generic;
using System.IO;

class FileInverted
{
    static void Main(string[] args)
    {
        string[] data = File.ReadAllLines("data1.txt");
        List<string> dataList = new List<string>(data);
        dataList.Reverse();
        File.WriteAllLines("data2.txt", dataList.ToArray());
        
    }
}

