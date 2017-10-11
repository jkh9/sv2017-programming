/*
 *  Maze Game
 * 
 *  V0.01 20-Sep-2017 Francisco Sabater: Main menu
 *  V0.02 29-Sep-2017 Gonzalo Martinez: Main menu do-while
 */
 
using System;

public class Maze
{
    public static void Main()
    {
        int option;
        
        do
        {
            Console.WriteLine("1.- New Game.");
            Console.WriteLine("2.- Load Game.");
            Console.WriteLine("3.- Help.");
            Console.WriteLine("4.- Credits.");
            Console.WriteLine("5.- Options.");
            Console.WriteLine("0.- Exit.");
            
            Console.Write("Select an option: ");
            option = Convert.ToInt32(Console.ReadLine());
            
            if(option == 1)
            {
                Console.WriteLine();
                Console.WriteLine("Option not available... yet");
                Console.WriteLine();
            }
            else if(option == 2)
            {
                Console.WriteLine();
                Console.WriteLine("Option not available... yet");
                Console.WriteLine();
            }
            else if(option == 3)
            {
                Console.WriteLine();
                Console.WriteLine("Option not available... yet");
                Console.WriteLine();
            }
            else if(option == 4)
            {
                Console.WriteLine();
                Console.WriteLine("Option not available... yet");
                Console.WriteLine();
            }
            else if(option == 5)
            {
                Console.WriteLine();
                Console.WriteLine("Option not available... yet"); 
                Console.WriteLine();  
            }
            else if(option == 0)
            {
                Console.WriteLine("Bye!");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Wrong option");
                Console.WriteLine(); 
            }
        }
        while(option != 0);
    }
}
