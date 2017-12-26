/*

Are going to get to the end of the month with any savings?


Entrada de ejemplo
7
100 -10
-10 -100
-10 100
100 -1000
2500 -2490
9500 -9500
-100 99

Salida de ejemplo
SI
NO
SI
NO
SI
SI
NO
*/

//Pedro Luis Coloma
using System;
public class ch40
{
    public static void Main ()
    {
        int cases = Convert.ToInt32(Console.ReadLine());
        short money;
        short taxes;
        
        for (int i = 0; i < cases; i++)
        {
            string[] data = Console.ReadLine().Split();
            money = Convert.ToInt16(data[0]);
            taxes = Convert.ToInt16(data[1]);

            if (money + taxes >= 0)
            {
                Console.WriteLine("SI");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
