/*
Luis Selles, Cesar Martin, Brandon Blasco, Kerubin Santana

*/

using System;

public class TresEnRaya
{
    public static void Main()
    {
        const int ROW = 3;
        const int COL = 3;
        int total = ROW * COL;
        int rows, cols;
        string[,] raya = new string[ROW,COL];
        bool acabado = true;
        char tirada;
        
        do
        {
            for(int i = 0; i < total; i++)
            {
                Console.Write("Enter column from 1 to 3: ");
                cols = Convert.ToInt32(Console.ReadLine());
                
                Console.Write("Enter row from 1 to 3: ");
                rows = Convert.ToInt32(Console.ReadLine());
                
                cols--;
                rows--;
                
                tirada = i%2 == 0 ? 'x':'O';
                
                if(raya[cols,rows] != "" )
                    raya[cols,rows] = Convert.ToString(tirada);
                else
                    Console.WriteLine("Error");
                    
                Console.WriteLine("|-----------|");
                Console.WriteLine("|  {0} | {1} | {2} |",raya[0,0], raya[0,1], 
                    raya[0,2]);
                Console.WriteLine("|-----------|");
                Console.WriteLine("|  {0} | {1} | {2} |",raya[1,0], raya[1,1], 
                    raya[1,2]);
                Console.WriteLine("|-----------|");
                Console.WriteLine("|  {0} | {1} | {2} |",raya[2,0], raya[2,1], 
                    raya[2,2]);
                Console.WriteLine("|-----------|");
            }
        }
        while(acabado);
    }
}
