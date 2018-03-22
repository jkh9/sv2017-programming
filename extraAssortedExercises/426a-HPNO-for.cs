// Display all the variations with the letters H, P, N, O, 
// maybe repeated (and count them)

// Javier Cases

using System;

public class Tema11
{
    public static void Main()
    {
        char[] letters = new char[4];
        letters[0] = 'h';
        letters[1] = 'p';
        letters[2] = 'n';
        letters[3] = 'o';

        int count = 0;

        for (int i = 0; i < letters.Length; i++)
            for (int j = 0; j < letters.Length; j++)
                for (int w = 0; w < letters.Length; w++)
                    for (int x = 0; x < letters.Length; x++)
                    {
                        Console.WriteLine("" + letters[i] + 
                            letters[j] + letters[w] + letters[x]);
                        count++;
                    }
        Console.WriteLine(count);
    }
}
