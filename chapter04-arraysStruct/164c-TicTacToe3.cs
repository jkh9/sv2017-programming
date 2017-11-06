// Gonzalo Martinez , Victor Tebar, Miguel Garcia , Miguel Pastor

using System;

public class TresEnRaya
{
    public static void Main()
    {
        const int SIZE = 3;
        int[,] board = new int[SIZE,SIZE];
        int row, column;
        bool win = false;
        int count = 0;
        
        do
        {
            Console.Write("Row? ");
            row = Convert.ToInt32(Console.ReadLine());
            Console.Write("Column? ");
            column = Convert.ToInt32(Console.ReadLine());
            
            board[row-1,column-1] = 1;
            
            Console.Clear();
            for(int i = 0; i < SIZE; i++)
            {
                for(int j = 0; j < SIZE; j++)
                {
                    Console.SetCursorPosition(i,j);
                    if(board[i,j] == 1)
                        Console.Write("X");
                    else if(board[i,j] == 2)
                        Console.Write("O");
                    else
                        Console.Write(" ");
                }
            }
            
            for(int i = 0; i < SIZE; i++)
            {
                for(int j = 0; j < SIZE; j++)
                {
                    Console.SetCursorPosition(j,i);
                    if(board[i,j] == 1)
                        Console.Write("X");
                    else if(board[i,j] == 2)
                        Console.Write("O");
                    else
                        Console.Write(" ");
                }
            }
            Console.WriteLine();
            
            //FILAS
            for(int i = 0; i < SIZE; i++)
            {
                count = 0;
                for(int j = 0; j < SIZE; j++)
                {
                    if(board[i,j] == 1)
                        count++;
                }
                if(count == 3)
                    win = true;
                else
                    count = 0;
            }
            
            //COLUMNAS
            for(int i = 0; i < SIZE; i++)
            {
                count = 0;
                for(int j = 0; j < SIZE; j++)
                {
                    if(board[j,i] == 1)
                        count++;
                }
                if(count == 3)
                    win = true;
                else
                    count = 0;
            }
            
            if(!win)
            {
                Console.Write("Row? ");
                row = Convert.ToInt32(Console.ReadLine());
                Console.Write("Column? ");
                column = Convert.ToInt32(Console.ReadLine());
            
                board[row-1,column-1] = 2;
            
                Console.Clear();
                for(int i = 0; i < SIZE; i++)
                {
                    for(int j = 0; j < SIZE; j++)
                    {
                        Console.SetCursorPosition(j,i);
                        if(board[i,j] == 1)
                            Console.Write("X");
                        else if(board[i,j] == 2)
                            Console.Write("O");
                        else
                            Console.Write(" ");
                    }
                }
                
                //FILAS
            for(int i = 0; i < SIZE; i++)
            {
                count = 0;
                for(int j = 0; j < SIZE; j++)
                {
                    if(board[i,j] == 2)
                        count++;
                }
                if(count == 3)
                    win = true;
                else
                    count = 0;
            }
            
            //COLUMNAS
            for(int i = 0; i < SIZE; i++)
            {
                count = 0;
                for(int j = 0; j < SIZE; j++)
                {
                    if(board[j,i] == 2)
                        count++;
                }
                if(count == 3)
                    win = true;
                else
                    count = 0;
            }
            
                Console.WriteLine();
            }
        }while(!win);
    }
}
