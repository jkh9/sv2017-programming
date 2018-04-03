/*
Sequence length and minimum

You are given a sequence of integers, separated with commas.  You are allowed 
to pick some contiguous segment of this sequence (that is, a segment without 
any gaps), and multiply the length of this segment by the minimum number in the 
segment.  What is the maximum value that you can generate in this manner?

For example, suppose the given sequence is 7,2,8,10.  If you pick the entire 
sequence,the length is 4 and the minimum number is 2,  so the product is 8.  If 
you pick the segment 8,10, the length is 2 and the minimum number is 8, so the 
product is 16.  This is the maximum value you can generate for this sequence.  
Note that you cannot pick 7,8,10, since it is not a contiguous segment

So...


Example input

7,2,8,10

Ouput for that input

16


In each of the cases below, you are given a sequence of values and you have to 
determine the maximum value that you can generate by picking a contiguous 
segment and multiplying its length by the minimum number in the segment.

(a) 5,14,8,7,6,10,10,4,2,5,30
(b) 24,22,16,18,6,7,17,16,5,20,8,19,16
(c) 15,30,23,1,47,23,3,8,9,10,19,21,13,5,4

(Source: Zonal Indian Informatics Olympiad, 2013, Problem 2)
*/


using System;

public class LengthAndMinimum
{
    public static int Minimum(string[] data, int from, int to)
    {
        int min = Convert.ToInt32(data[from]);
        for (int i = from+1; i <= to; i++)
            if (Convert.ToInt32(data[i]) < min)
                min = Convert.ToInt32(data[i]);
        return min;
    }
    
    public static void Main(string[] args)
    {
        string[] numStr = Console.ReadLine().Split(',');
        int max = 0;
        for (int len = 1; len < numStr.Length; len++)
        {
            for(int pos = 0; pos < numStr.Length - len + 1; pos++)
            {
                int min = Minimum(numStr, pos, pos+len-1);
                if (min*len > max)
                    max = min*len;
            }
        }
        Console.WriteLine(max);
    }
}
