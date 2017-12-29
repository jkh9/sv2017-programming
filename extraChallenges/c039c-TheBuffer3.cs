// Lucía Navarro Vélez
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

using System;

public class Ejer02
{
    public static void Main()
    {
        int casos, urinarios, disponibles = 0;
        casos = Convert.ToInt32(Console.ReadLine());
        do
        {
            urinarios = Convert.ToInt32(Console.ReadLine());
            disponibles = urinarios / 2;
            Console.WriteLine(urinarios - disponibles);
            casos--;
        } while (casos != 0);
    }
}
