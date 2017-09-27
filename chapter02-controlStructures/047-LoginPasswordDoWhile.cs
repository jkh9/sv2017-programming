/* Write a C# program to ask the user for a numeric login and a numeric 
password. They will not be allowed to go on until they enter the correct login 
(1) and password (1234). You must use do-while. */

using System;

public class LoginPassDoWhile
{
    public static void Main()
    {
        int login = 666, password = 1234;
        int enteredLogin, enteredPassword;
            
        do
        {
            Console.Write("Enter login again: ");
            enteredLogin = Convert.ToInt32(Console.ReadLine());
        
            Console.Write("Enter password again: ");
            enteredPassword = Convert.ToInt32(Console.ReadLine());
            
            if ((enteredLogin != login) || (enteredPassword != password))
                Console.WriteLine ("Incorrect login or password");

        }
        while ((enteredLogin != login) || (enteredPassword != password));
        Console.WriteLine ("Welcome mister president!");
    }
}
