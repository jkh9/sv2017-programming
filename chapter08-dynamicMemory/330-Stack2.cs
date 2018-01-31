/* Ask the user for 5 integer numbers and display them reversed,
 * using a Stack */

using System;
using System.Collections;

public class Ex330
{
    public static void Main()
    {
        Stack myStack = new Stack();
        for(int i = 0; i < 5; i++)
            myStack.Push( Convert.ToInt32(Console.ReadLine()) );

        for(int i = 0; i < 5; i++)
            Console.Write((int) myStack.Pop() + " ");
    }
}
