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

// Gonzalo Martinez

using System;

public class Challenge017
{
    public static void Main()
    {
        int num, res;
        bool finished = false;
        bool check = true;
        
        do
        {
            check = true;
            num = Convert.ToInt32(Console.ReadLine());
            
            if(num >= 0)
            {
                for(int i = 0; i < num; i++)
                {
                    res = num % 10;
                    num /= 10;
                    if(res % 2 != 0)
                        check = false;
                }
                if(num % 2 != 0)
                    check = false;
                        
                if(check)
                    Console.WriteLine("SI");
                else
                    Console.WriteLine("NO");
            }
            else
                finished = true;
                
        }while(!finished);
    }
}
