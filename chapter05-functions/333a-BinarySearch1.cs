// Binary Search
// Moisés Encinas Picazo

using System;

public class Clase
{
    public static void Main()
    {
        int[] data = new int[7]{ 1, 3, 5, 7, 9, 15,20 };

        for(int i=0; i<=21; i++)
            if (BinSearch(data, i, 0, 6))
                Console.WriteLine("{0} is there", i);
            else
                Console.WriteLine("{0} is not there", i);
    }

    public static bool BinSearch(int[] array,int number,
        int startP, int finalP)
    {
        int midlePoint = ((finalP - startP)/2) + startP;

        //Base Case
        if (array[startP] == number || array[finalP] == number ||
            array[midlePoint] == number)
        {
            return true;
        }
        else if (finalP - startP == 2 || number > array[finalP] ||
            number < array[startP])
        {
            return false;
        }
        else
        {
            if (array[midlePoint] > number)
            {
                return BinSearch(array, number, startP, midlePoint-1);
            }
            else
            {
                return BinSearch(array, number, midlePoint+1, finalP);
            }
        }
    }
}
