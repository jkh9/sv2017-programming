/* Ask the user for as many strings as they like, using a Stack to store the 
data temporarily. When the user enters an empty string, you must display all 
the strings entered so far reversed (and exit the program) */

using System;
using System.Collections;

public class Ex324a
{
    public static void Main()
    {
        Stack myStack = new Stack();
        string data;
        do
        {
            data = Console.ReadLine();
            if(data != "")
                myStack.Push(data);
        }
        while(data != "");
        
        int amount = myStack.Count;
        for(int i = 0; i < amount; i++)
        {
            Console.WriteLine(myStack.Pop());
        }
    }
}
