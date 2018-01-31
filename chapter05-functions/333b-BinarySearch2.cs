// Binary Search
// Querubin Santana

using System;


public class Program
{
    public static void Main()
    {
        int[] numsarray = {1,3,5,7,9,15,20};
        
        for(int i=0; i<=21; i++)
            if (BinarySearch(numsarray, i, 0, numsarray.Length))
                Console.WriteLine("{0}... Yeeeah", i);
            else
                Console.WriteLine("{0}... Nope", i);
    }
    
    public static bool BinarySearch(int[] numsarray, int searchnum,
        int posStart, int posEnd)
    {
        int difference=posEnd-posStart;
        int actualpos=posStart+(difference/2);
        
        if(numsarray[actualpos]==searchnum)
        {
            return true;
        }
        else if(difference==1 && numsarray[actualpos]!=searchnum)
        {
            return false;
        }
        else if(numsarray[actualpos]>searchnum)
        {
            return BinarySearch( numsarray, searchnum, posStart, actualpos);
        }
        else if(numsarray[actualpos]<searchnum)
        {
            return BinarySearch( numsarray, searchnum, actualpos, posEnd);
        }
        else
        {
            return false;
        }
    }
}
