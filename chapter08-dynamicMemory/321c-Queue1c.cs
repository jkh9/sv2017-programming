/*
Ask the user for as many strings as they like, 
using a Queue to store the data temporarily. 
When the user enters an empty string, you must 
display all the strings entered so far (and exit
the program)
*/

//Jose Vilaplana
using System;
using System.Collections;

public class Ex321b
{
    public static void Main()
    {
        Queue myQueue = new Queue();
        string dataToQueue;
        do
        {
            dataToQueue = Console.ReadLine();
            if(dataToQueue != "")
                myQueue.Enqueue(dataToQueue);
        }
        while(dataToQueue != "");
        
        foreach(string s in myQueue)
        {
            Console.WriteLine(s);
        }
        Console.WriteLine("Remaining: "+myQueue.Count);
    }
}
