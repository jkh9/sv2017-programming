/*
Ex.360 - Stack of integers + Enumerator

Create a C# program to ask the user for integer numbers. It will store each 
number in a stack, except if it is equal to the last number entered. When the 
user presses Enter instead of entering a valid number, the program will display 
the contents of the stack, tell the user if the number 5 was in the stack or 
not, and finish.

*/

using System;
using System.Collections.Generic;

public class StackOfIntegers
{
    public static void Main()
    {
        Stack<int> s = new Stack<int>();
        
        // Data input
        Console.Write("Enter data: ");
        string previousData = "";
        string data = Console.ReadLine();
        while (data != "")
        {
            if (data != previousData)
                s.Push( Convert.ToInt32( data ));
            previousData = data;
            Console.Write("Enter data: ");
            data = Console.ReadLine();
        }
        
        // Data retrieval
        bool fiveFound = false;
        IEnumerator<int> myEnum = s.GetEnumerator(); 
        while ( myEnum.MoveNext() ) 
        {
            int n = myEnum.Current;
            if (n == 5)
                fiveFound = true;
            Console.Write( n + " ");
        }
        Console.WriteLine();
        
        Console.WriteLine( fiveFound ? "5 was there" : "5 was not there");
    }
}
