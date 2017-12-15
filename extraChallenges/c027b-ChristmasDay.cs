/*
Acepta 362: ¿Es día de Navidad?
 
Example input

2
25 12
03 05

Example output

SI
NO
*/
using System;

public class Acepta362
{
    public static void Main()
    {
        int cases = Convert.ToInt32(Console.ReadLine());
        
        for(int i = 0; i < cases; i++)
        {     
            if (Console.ReadLine() == "25 12")
                Console.WriteLine("SI");
            else
                Console.WriteLine("NO");
        }
    }
}
