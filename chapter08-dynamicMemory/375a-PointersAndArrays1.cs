using System;

class Ex375
{
    static unsafe void Main(string[] args)
    {
        const int SIZE = 5;

        int* data = stackalloc int[SIZE];

        for (int i = 0; i < SIZE; i++)
        {
            data[i] = i * 10;
        }

        for (int i = 0; i < SIZE; i++)
        {
            Console.WriteLine(data[i]);
        }

    }
}
