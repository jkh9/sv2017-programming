// Challenge 021 - Robot busca-tesoros
// Almudena Lopez Sanchez, minor corrections by Nacho

// Note: not perfect, fails with 4th test case

/*
Ejemplo de entrada
10 10
1 1
3 3
2
1 2
4 3

Ejemplo de salida
TESORO

Ejemplo de entrada
4 4
1 1
4 4
2
1 2
2 1

Ejemplo de salida
IMPOSIBLE

10 5
6 1
7 3
2
1 2
4 3

Ejemplo de salida
TESORO
Ejemplo de entrada
10 10
1 1
3 3
4
1 2
2 2
3 2
4 3
*/

using System;
public class Challenge21
{
    public static void Main()
    {
        bool debugging = true;
        
        string mapC = Console.ReadLine();
        string [] nums = mapC.Split();
        int width = Convert.ToInt32(nums[0]);
        int height = Convert.ToInt32(nums[1]);
        char[,] map = new char[width,height];
        
        string robotC = Console.ReadLine();
        nums = robotC.Split();
        int rX = Convert.ToInt32(nums[0])-1;
        int rY = Convert.ToInt32(nums[1])-1;
        if (debugging)
            map[rX,rY] = 'R';

        string treasureC = Console.ReadLine();
        nums = treasureC.Split();
        int tX = Convert.ToInt32(nums[0])-1;
        int tY = Convert.ToInt32(nums[1])-1;
        if (debugging)
            map[tX,tY] = 'T';

        int num = Convert.ToInt32(Console.ReadLine());
        string line;
        for(int i = 0; i < num; i++)
        {
            line = Console.ReadLine();
            nums = line.Split();
            map[Convert.ToInt32(nums[0])-1, 
                Convert.ToInt32(nums[1])-1] = 'x';
        }
        
        if (debugging)
        {
            for(int row = 0; row < height; row++)
            {
                for(int col = 0; col < width; col++)
                {
                    if (map[col, row] == '\0')
                        Console.Write('.');
                    else
                        Console.Write(map[col, row]);
                }
                Console.WriteLine();
            }
        }

        bool correct = false;
        bool moveX = true;
        bool moveY = true;
        do
        {
            if ((rX != tX))
            {
                if (rX > tX)
                {
                    if (map[rX - 1, rY] != 'x')
                    {
                        rX--;
                        moveX = true;
                    }
                    else
                        moveX = false;
                }
                else
                {
                    if (map[rX + 1, rY] != 'x')
                    {
                        rX++;
                        moveX = true;
                    }
                    else
                        moveX = false;
                }     
            }
            else if (rY != tY)
            {
                if (rY > tY)
                {
                    if (map[rX, rY - 1] != 'x')
                    {
                        rY--;
                        moveY = true;
                    }
                    else
                        moveY = false;
                }
                else
                {
                    if (map[rX, rY + 1] != 'x')
                    {
                        rY++;
                        moveY = true;
                    }
                    else
                        moveY = false;
                }
            }
            else
                correct = true;
        }
        while (!correct && (moveY && moveX));
        Console.WriteLine(!correct ? "IMPOSIBLE" : "TESORO");
    }
}
