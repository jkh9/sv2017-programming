//
// Miguel Puerta
// Challenge 20 Snake

/*
Ejemplo de entrada

4
3 3
3 4
5 3
9 9

Ejemplo de salida

Caso 1
###
..#
###
Caso 2
####
...#
####
Caso 3
###
..#
###
#..
###
Caso 4
#########
........#
#########
#........
#########
........#
#########
#........
#########
*/

using System;

public class SnakeSimpson
{
    public static void Main()
    {
        const int SIZE = 2;
        string[] strMN = new string[SIZE];
        
        int c = Convert.ToInt32(Console.ReadLine());
        
        while(c > 0)
        {
            do
            {
                strMN = Console.ReadLine().Split();
            }while(Convert.ToInt32(strMN[0]) % 2 == 0);
            
            for(int i = 0; i < Convert.ToInt32(strMN[0]); i++)
            {
                if((i+1) % 4 == 0)
                {
                    Console.Write("#");
                    
                    for(int j = 0; j < Convert.ToInt32(strMN[1]) - 1; j++)
                        Console.Write(".");
                }
                else if((i+1) % 2 == 0)
                {
                    for(int j = 0; j < Convert.ToInt32(strMN[1]) - 1; j++)
                        Console.Write(".");
                        
                    Console.Write("#");
                }
                else
                {
                    for(int j = 0; j < Convert.ToInt32(strMN[1]); j++)
                        Console.Write("#");
                }
                Console.WriteLine();
            }
            
            c--;
        }
    }
}
