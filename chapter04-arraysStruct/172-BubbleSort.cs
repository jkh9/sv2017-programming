/*
Create a program to ask the user for 10 integer numbers (from -1000 to 1000), 
sort them and display them sorted.

Note: You can use bubble sort, for example, whose algorithm is:

BubbleSort (1)
(Exchange every consecutive pair that is not ordered)

For i = 1 to n-1
    For j = i +1 to n
        If A[i] > A[j]
          Swap (A[i], A[j])
*/

// Javier Herreros Pozo

using System;

class BubbleSort
{
    static void Main(string[] args)
    {
        const int SIZE = 10;

        /*int[] data = new int[SIZE];

        for (int i = 0; i < SIZE; i++)
        {
            Console.WriteLine("Enter data for pos {0}:", i+1);
            data[i] = Convert.ToInt32(Console.ReadLine());
        }*/

        int[] data =  new int[SIZE] { 20, 25, 18, 21, 14, 
            13, 30, 7, 5, 1};
            
        foreach(int d in data)
            Console.Write(d+" ");
        Console.WriteLine();

        for (int i = 0; i < SIZE-1; i++)
        {
            for (int j = i+1; j < SIZE; j++)
            {
                if (data[i] > data[j])
                {
                    int temp = data[j];
                    data[j] = data[i];
                    data[i] = temp;
                }
            }
            
            foreach(int d in data)
                Console.Write(d+" ");
            Console.WriteLine();
        }
    }
}
