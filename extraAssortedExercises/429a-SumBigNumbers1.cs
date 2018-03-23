// Sum big numbers

using System;

public class SumBigNumbers
{
    public static string Sum(string num1, string num2)
    {
        string result="";
        bool carry = false;
        
        // num2 will be the shortest number
        if (num1.Length < num2.Length)
        {
            string temp = num1;
            num1 = num2;
            num2 = temp;
        }

        // now let's pad num2 with zeroes
        if (num1.Length != num2.Length)
        {
            string startingZeroes = new string('0', num1.Length - num2.Length);
            num2 = startingZeroes + num2;
        }
        
        // and finally, let's sum , right to left
        int pos = num1.Length-1;

        while(pos >= 0)
        {
            int n1 = Convert.ToInt32(num1.Substring(pos, 1));
            int n2 = Convert.ToInt32(num2.Substring(pos, 1));

            int sum = n1+n2;
            if(carry)
            {
                sum++;
                carry=false;
            }
            if(sum >= 10)
            {
                sum %= 10;
                carry = true;
            }
            result = "" + sum + result;
            pos--;
        }
                
        // there might be a carry in the first digit
        if(carry)
            result="1"+result;

        return result;
    }
    
    public static void Main()
    {
        // Tests
        if (Sum("2", "3") != "5")
            Console.WriteLine("Incorrect 2+3: " + Sum("2", "3"));
        if (Sum("5", "5") != "10")
            Console.WriteLine("Incorrect 5+5: " + Sum("5", "5"));
        if (Sum("25", "36") != "61")
            Console.WriteLine("Incorrect 25+36: " + Sum("25", "36"));
        if (Sum("555", "555") != "1110")
            Console.WriteLine("Incorrect 555+555: " + Sum("555", "555"));
                
        // Real program logic
        string num1 = Console.ReadLine();
        string num2 = Console.ReadLine();
        Console.WriteLine(Sum(num1, num2));
    }
}
