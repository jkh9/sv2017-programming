//Miguel García Gil

/* Write a C# program to ask the user for a numeric login and a numeric 
password. They will not be allowed to go on until they enter the correct login 
(1) and password (1234). */

using System;

public class LoginPass
{
    public static void Main()
    {
        int login = 666, password = 1234;
        int enteredLogin, enteredPassword;
        Console.Write("Enter login: ");
        enteredLogin = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter password: ");
        enteredPassword = Convert.ToInt32(Console.ReadLine());
            
        while ((enteredLogin != login) || (enteredPassword != password))
        {
            Console.WriteLine ("Incorrect login or password");
            
            Console.Write("Enter login again: ");
            enteredLogin = Convert.ToInt32(Console.ReadLine());
        
            Console.Write("Enter password again: ");
            enteredPassword = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine ("Welcome mister president!");
    }
}
