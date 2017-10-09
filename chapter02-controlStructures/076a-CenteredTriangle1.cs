// Javier Cases Sempere

using System;

public class Ex76
{
    public static void Main()
    {
        Console.Write("Enter a Base Size: ");
        int size = Convert.ToInt32(Console.ReadLine());
        
        int space = size % 2 == 0 ? (size / 2) - 1 : size / 2;
        
        int sizeNow = size % 2 == 0 ? 2 : 1;
        
        while (sizeNow <= size)
        {
            for (int columnSpace = space; columnSpace > 0; columnSpace--)
                Console.Write(" ");
            
            for (int column = sizeNow ; column > 0; column--)
                Console.Write("#");
                
            sizeNow += 2;
            space--;
            
            Console.WriteLine();

        }
    }
}
