/*
 * Raul Gogna
 * Square, new string
*/

using System;

public class Ex177
{
    public static void Main()
    {
        Console.Write("Size of the square: ");
        int size = Convert.ToInt32(Console.ReadLine());
        string line = new String('*', size);
        
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine(line);
        }
    }
}

