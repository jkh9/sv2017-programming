
//Triangle
//Querubin Santana

using System;

public class Triangle
{
    public static void Main()
    {
        int size;
        char symbol;
        int spaces;
        
        Console.Write("Enter the size: ");
        size = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter the symbol: ");
        symbol = Convert.ToChar(Console.ReadLine());
        
        spaces=0;
        
        for(int i = 0; i < size; i++)
        {
            for(int x = 0; x < size; x++)
            {
                if(spaces <= x)
                    Console.Write(symbol);
                else
                    Console.Write(" ");
                
            }
            Console.WriteLine();
            spaces++;
        }
    }
}
