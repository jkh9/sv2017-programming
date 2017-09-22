// Victor Tebar
// Asks the user for a password, as many times as needed

using System;

public class Ejer36
{
    public static void Main()
    {
        int password = 1234, enteredPassword = 0;
        
        while(enteredPassword != password)
        {
            Console.Write("Enter the password: ");
            enteredPassword = Convert.ToInt32(Console.ReadLine());
            if(enteredPassword != password)
                Console.WriteLine("Wrong password");
        }
        Console.WriteLine("Welcome");
    }
}
