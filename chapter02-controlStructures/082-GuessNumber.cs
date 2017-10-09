// Guess a number
// Pedro Luis Coloma Lloret

using System;
public class GuessingGame
{   
    public static void Main()
    {
        int hidden = 29;
        int answer;
        
        do
        {
            Console.Write("Enter your guess: ");
            answer = Convert.ToInt32(Console.ReadLine());
            if (answer > hidden)
                Console.WriteLine("Too high.");
            else if (answer < hidden)
                Console.WriteLine("Too low.");
        }
        while (answer != hidden);
        
        Console.WriteLine("You did it!");
    }
}
