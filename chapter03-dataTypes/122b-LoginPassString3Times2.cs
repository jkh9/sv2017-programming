/*
Write a program to ask the user for his/her name and his/her password 
(both must be strings) and repeat it as many times as necessary (with a 
limit of 3 attempts), until the entered name is "john" and the password 
is "password".
*/

using System;

public class LoginPassString3times
{
    public static void Main()
    {
        string userLogin, userPass;
        int attempts = 0;
        
        do
        {
            Console.Write("Enter login: ");
            userLogin = Console.ReadLine();
            Console.Write("Enter pass: ");
            userPass = Console.ReadLine();
            
            attempts ++;
            
            if ((userLogin != "john") || (userPass != "password"))
                Console.WriteLine(
                    "Access denied. {0} attempts left", 
                    3-attempts);
        }
        while ((((userLogin != "john") || (userPass != "password"))) 
            && (attempts < 3));
        
        if ((userLogin == "john") && (userPass == "password"))
            Console.WriteLine("Access granted");
        else
            Console.WriteLine("Access denied");
    }
}
