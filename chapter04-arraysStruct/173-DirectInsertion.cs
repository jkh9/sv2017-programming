/*
Create a program to test the "direct insertion" sorting algorithm.

Compare each item with the ones above, which are already sorted, and 
move it to the its correct position.

For i = 2 to n
    j = i-1
    while (j >= 1) and (A[j] > A[j +1])
        Swap (A[j], A[j +1])
        j = j - 1
*/

// Pedro Luis Coloma LLoret

using System;

public class DirectInsertion
{
    public static void Main()
    {
        const int SIZE = 10;
        
        /*int[] data = new int[SIZE];

        for (int i = 0; i < SIZE; i++)
        {
            Console.Write("Enter value #" + (i + 1) + " in data: ");
            data[i] = Convert.ToInt32(Console.ReadLine());
        }*/
        
        int[] data =  new int[SIZE] { 20, 25, 18, 21, 14, 
            13, 30, 7, 5, 1};
        
        for (int i = 1; i < SIZE; i++)
        {
            int j=i-1;
            while ((j >= 0) && (data[j] > data[j+1]))
            {
                if (data[j] > data[j+1])
                {
                    int temp = data[j];
                    data[j] = data[j + 1];
                    data[j + 1] = temp;
                }
                j--;    
            }
            
            // And let's see the progress...
            foreach(int d in data)
                Console.Write(d+" ");
            Console.WriteLine();
        }
    }
}
