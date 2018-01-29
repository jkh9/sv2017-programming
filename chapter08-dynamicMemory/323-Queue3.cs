//Daniel Miquel Sirera

using System;
using System.Collections;

class Program
{
    static void Main()
    {
        Queue myQueue = new Queue();
        string word;

        do
        {
            do
            {
                word = Console.ReadLine();
                if (word != "" && word != "quit")
                {
                    myQueue.Enqueue(word);
                }
            } while (word != "" && word != "quit");

            if (word != "quit")
            {
                Object[] myArray = myQueue.ToArray();
                foreach (string word2 in myArray)
                {
                    Console.WriteLine(word2);
                }
            }
        } while (word != "quit");
    }
}

