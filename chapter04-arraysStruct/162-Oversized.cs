/*
Create an array with space for 10000 double precision data. 
Display a menu which will allow the user to:

1: Add new data (several data, one at a time, 
    until they press Enter not entering any number).
2: View data (all of them in a row).
0: Exit
*/

// Gonzalo Martinez

using System;

public class Ex162
{
    public static void Main()
    {
        double[] data = new double[10000];
        int option, count = 0;
        
        do
        {
            Console.WriteLine("1.-Add data:");
            Console.WriteLine("2.-Show data:");
            Console.WriteLine("3.-Exit");
            Console.WriteLine();
            
            Console.Write("Option? ");
            option = Convert.ToInt32(Console.ReadLine());
            
            if (option == 1)
            {
                Console.Write("Enter a real number: ");
                data[count] = Convert.ToDouble(Console.ReadLine());
                count++;
            }
            else if (option == 2)
            {
                for(int i = 0; i < count; i++)
                {
                    Console.Write(data[i] + " ");
                }
                Console.WriteLine();
            }
            else if (option == 3)
            {
                Console.WriteLine("Bye!");
            }
            else
            {
                Console.WriteLine("Not a possible option!");
            }        
        }
        while(option != 3);
    }
}
