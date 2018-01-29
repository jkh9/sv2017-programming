/*
Ask the user for as many strings as they like, using a Queue to store the data 
temporarily. When the user enters an empty string, you must display all the 
strings entered so far and start asking for more strings. The program will 
finish when the user enters “quit”
*/

// Moisés Encinas

using System;
using System.Collections;

class Program
{
    static void Main()
    {
        Queue myQueue = new Queue();
        string option;
        do
        {
            do
            {
                option = Console.ReadLine();
                if (option != "" && option != "quit")
                {
                    myQueue.Enqueue(option);
                }
            } 
            while (option != "" && option != "quit");

            if (option != "quit")
            {
                int amount = myQueue.Count;
                for (int i = 0; i < amount; i++)
                {
                    Console.WriteLine(myQueue.Dequeue());
                }
            }

        } while (option != "quit");
    }
}
