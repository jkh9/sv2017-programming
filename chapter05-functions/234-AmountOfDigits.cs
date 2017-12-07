// Gonzalo Martinez
// Amount of digits, iterative and recursive

using System;

public class Ex234
{
    public static int AmountOfDigits(int n)
    {
        int count = 0;
        
        while(n > 0)
        {
            count++;
            n /= 10;
        }
        return count;
    }
    
    public static int AmountOfDigitsR(int n)
    {
        if(n < 10)
            return 1;
            
        return 1 + AmountOfDigitsR(n / 10);
    }
    
    public static void Main()
    {
        Console.WriteLine(AmountOfDigits(987));
        
        if(AmountOfDigitsR(1005) != 4)
            Console.Write("Bug found!");
    }
}
