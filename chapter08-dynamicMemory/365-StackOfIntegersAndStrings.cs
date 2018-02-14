/*

Ex.365 - Stack of numbers and strings

Create a program to allow the user to enter a string and then a number, and so 
on, until they enter an empty string. Then you will display the longest word 
and the average of the numbers.

*/

using System;
using System.Collections;

public class Ex365
{
    public static void Main()
    {
        Stack stack = new Stack();
        string word;
        double number;

        do
        {
            Console.Write("Word: ");
            word = Console.ReadLine();
            if (word != "")
            {
                stack.Push(word);
                Console.Write("Number: ");
                number = Convert.ToDouble(Console.ReadLine());
                stack.Push(number);
            }
        } while (word != "");

        int stackSize = stack.Count;
        double total = (double)stack.Pop();
        string largest = (string)stack.Pop();

        for (int i = 0; i < stackSize / 2; i++)
        {
            total += (double)stack.Pop();
            word = (string)stack.Pop();
            largest = 
                word.Length > largest.Length ? 
                word : largest;
        }

        Console.WriteLine("The average is " + total / (stackSize/2) );
        Console.WriteLine("The largest word is" + largest);
    }
}
