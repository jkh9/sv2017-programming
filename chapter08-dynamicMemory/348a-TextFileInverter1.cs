// Create a C# program to invert the contents of a text file 
// (and dump it to a new file), using a dynamic structure.

//Miguel García Gil

using System;
using System.IO;
using System.Collections;

class Ex348
{
    static void Main()
    {
        ArrayList myList = new ArrayList();

        string[] data = File.ReadAllLines("example.txt");

        for(int i = 0; i < data.Length; i++)
        {
            myList.Add(data[i]);
        }

        for(int i = data.Length - 1; i >= 0; i--)
        {
            data[data.Length - i - 1] = (string) myList[i];
        }

        File.WriteAllLines("example.txt", data);
    }
}
