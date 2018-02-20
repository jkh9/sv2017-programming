using System;

class Ex375
{
    static unsafe void Main(string[] args)
    {
        const int SIZE = 5;

        int* data = stackalloc int[SIZE];

        int* pos = data;

        *pos = 5;

        pos++;
        *pos = 3;

        *(++pos) = 2;

        data[3] = 6;
        pos[2] = 1;


        for (int i = 0; i < SIZE; i++)
        {
            Console.WriteLine(data[i]);
        }

    }
}
