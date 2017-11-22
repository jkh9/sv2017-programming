/*
Se dice que un número es hyperpar cuando todos sus dígitos son pares

Entrada de ejemplo
2460
1234
2
-1
Salida de ejemplo
SI
NO
SI
*/
//Almudena Lopez Sanchez
using System;
public class Challenge17
{
    public static void Main()
    {
        bool correct;
        string nums;
        do
        {
            correct = true;
            nums = Console.ReadLine();
            if(Convert.ToInt32(nums) >= 0)
            {
                foreach (char n in nums)
                {
                    //Console.WriteLine(n);
                    if (Convert.ToByte(n) % 2 != 0)
                        correct = false;
                }
                Console.WriteLine(correct ? "SI": "NO");
            }
        }
        while(Convert.ToInt32(nums) >= 0);
        
    }
}
