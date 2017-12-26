/*

The buffer!
Input

The first line will contain the number of cases.
After that, each line will be the numbers of wall-mounted urinals in a bathroom.

Output

The number of men that can use the urinals simultaneously.

Sample Input

5
1
2
3
4
5

Sample Output

1
1
2
2
3
*/

// Pedro Luis Coloma

using System;
public class ch39
{
    public static void Main ()
    {
        int cases = Convert.ToInt32(Console.ReadLine());
        int boxes;
        int ManlyMans;
        
        for (int i = 0; i < cases; i++)
        {
            boxes = Convert.ToInt32(Console.ReadLine());

            if (boxes % 2 == 0)
            {
                ManlyMans = boxes/2;
            }
            else
            {
                ManlyMans = (boxes+1)/2;
            }
            Console.WriteLine(ManlyMans);
        }
    }
}
