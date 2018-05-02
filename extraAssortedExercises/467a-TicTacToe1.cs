//Almudena Lopez, Luis Martín, Miguel Pastor
// V1: Approx 1.750 bytes
using System;

public class TicTacToe
{
    protected static Token player1 = new Token('x');
    protected static Token player2 = new Token('O');
    public static void DrawToken(int num,Token p)
    {
        switch(num)
        {
            case 1:
                break;
        }
    }
    public static void Board()
    {
        int posX = 1;
        int posY = 1;

        for (int row = 0; row < 3; row++)
        {
            for (int col = 0; col < 3; col++)
            {
                Console.SetCursorPosition(posX, posY);
                Console.Write(" ___");
                posY += 1;
                Console.SetCursorPosition(posX, posY);
                Console.Write("|   |");
                posY += 1;
                Console.SetCursorPosition(posX, posY);
                Console.Write("|___|");
            }
            posY =1;
            posX +=4;
        }
        
        Console.SetCursorPosition(1, 10);
    }
    public static void Main()
    {
        bool exit = false;
        do
        {
            Board();
            Console.WriteLine("Player1:");
            DrawToken(Convert.ToInt32(Console.ReadLine()),player1);
            Console.WriteLine("Player2:");
            DrawToken(Convert.ToInt32(Console.ReadLine()),player2);
            Console.Clear();
        }
        while (!exit);
    }
}
// ---
public class Token
{
    protected int x;
    protected int y;

    char sprite;

    public Token(char sprite)
    {
        this.sprite = sprite;
        x = 3;
        y = 3;
    }

    public void MoveTo(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

}
