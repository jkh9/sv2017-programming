// Ask the user for as many strings as they like,
// using an ArrayList to store the data, until 
// they enter an empty string
// 
// Then, the user will choose a number 
// (such as 2) and that string (the second) 
// will be displayed. The program will finish 
// when the user enters 0.

using System;
using System.Collections;

class ArrList
{
    static void Main(string[] args)
    {
        ArrayList list = new ArrayList();
        string data = Console.ReadLine();
        while (data != "")
        {
            list.Add(data);
            data = Console.ReadLine();
        }

        int pos = Convert.ToInt32(Console.ReadLine());
        while (pos != 0)
        {
            Console.WriteLine(list[pos-1]);
            pos = Convert.ToInt32(Console.ReadLine());
        }
    }
}
