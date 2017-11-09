//Marcos Cervantes
//Direct Selection
using System;
public class DirectSelection
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
        
        foreach(int d in data)
                Console.Write(d+" ");
            Console.WriteLine();
       
        for(int i = 0; i < SIZE-1; i++)
        {
            int smallestPosition = i;
            for (int j = i +1; j < SIZE; j++)
            {
                if(data[j] < data[smallestPosition])
                {
                    smallestPosition = j;
                }
            }
            if(smallestPosition != i)
            {
                int temp = data[i];
                data[i] = data[smallestPosition];
                data[smallestPosition] = temp;
            }
            
            foreach(int d in data)
                Console.Write(d+" ");
            Console.WriteLine();
        }        
    }               
}
