// Pedro Luis Coloma

using System;
using System.Collections;

class Dinmemo
{
    static void Main(string[] args)
    {
        ArrayList myList = new ArrayList();
        for (int i = 0; i < 5; i++)
        {
            myList.Insert(0, Convert.ToInt32(Console.ReadLine()));
        }

        for (int i = 0; i < myList.Count; i++)
        {
            Console.Write(myList[i] + " ");
        }
        Console.WriteLine();
    }
}
