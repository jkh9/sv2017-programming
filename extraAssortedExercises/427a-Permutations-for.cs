// Display the permutations of the letters H, P, N, O

// Marcos Cervantes

using System;
using System.Text;

public class Item
{
    public static void Main()
    {
        int count = 0;
        char[] arr = { 'h', 'p', 'n', 'o' };
        for (int i = 0; i <= 3; i++)
        {
            for (int j = 0; j <= 3; j++)
            {
                for (int z = 0; z <= 3; z++)
                {
                    for (int x = 0; x <= 3; x++)
                    {
                        if (i != j && i != z && i != x && j != z && j != x
                            && z != x)
                        {
                            Console.WriteLine("" + 
                                arr[i] + arr[j] + arr[z] + arr[x]);
                            count++;
                        }
                    }
                }
            }
        }
        Console.WriteLine(count);
    }
}
