using System;

public class PasswordDoWhile
{
    public static void Main()
    {
        int password;
        
        do
        {
            Console.WriteLine("Enter password: ");
            password = Convert.ToInt32(Console.ReadLine());
            
            if (password != 1234)
                Console.WriteLine("Incorrect password");
        }
        while (password != 1234);
        
        Console.WriteLine("Welcome!");
    }
}
