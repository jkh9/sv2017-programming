// Ask the user for 10 short integer numbers and
// display thwm sorted

using System;

class BubbleSortShort
{
    static void Main(string[] args)
    {
        const byte SIZE = 10;

        short[] data = new short[SIZE];

        for (int i = 0; i < SIZE; i++)
        {
            Console.WriteLine("Enter data for pos {0}:", i+1);
            data[i] = Convert.ToInt16(Console.ReadLine());
        }

        for (byte i = 0; i < SIZE-1; i++)
        {
            for (byte j = (byte) (i+1); j < SIZE; j++)
            {
                if (data[i] > data[j])
                {
                    short temp = data[j];
                    data[j] = data[i];
                    data[i] = temp;
                }
            }
        }

        foreach(int d in data)
            Console.Write(d+" ");
        Console.WriteLine();

    }
}
