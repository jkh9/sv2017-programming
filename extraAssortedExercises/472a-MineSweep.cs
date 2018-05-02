//Daniel Miquel Sirera, Cesar Martín Sogorb, Luis Selles Blanes
// V1: Approx 2.325 bytes
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MineSweep_Game
{
    public static void Main()
    {
        MineSweep_Screen.Screen();

    }
}

// ---
class MineSweep_Screen
{
    public MineSweep_Screen() { }

    public static void Screen()
    {
        string space = "   ";
        string point = ".";
        string inside = " ";

        for (int col = 0; col < 11; col++)
        {
            Console.Write(point);
            for (int row = 0; row < 10; row++)
            {
                Console.Write(space);
                Console.Write(point);
            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(inside);
            }
            Console.WriteLine();
        }
        Console.ResetColor();
    }
}
// ---
class MineSweep_Mines
{
    protected int[] mines = new int[30];
    protected List<string> listMine = new List<string>();

    //Function to get an array of 30 mines.
    public List<string> getMines()
    {

        int number;
        for (int i = 0; i < 100; i++)
        {
            listMine.Insert(i, "o");
        }

        for (int i = 0; i < 30; i++)
        {
            do
            {
                Random r = new Random();
                number = r.Next(100);

            } while (mines.Contains(number));
            mines[i] = number;
            listMine.Insert(number, "x");
        }



        return listMine;
    }

}
// ---

public class MineSweep_Movement
{
    protected static int height;
    protected static int width;
    protected int column;
    protected int row;
    protected static int posList;

    public MineSweep_Movement(int column, int row)
    {
        this.column = column;
        this.row = row;
    }

    public static int PosX(int col)
    {
        width = (col - 1) * 4;
        return width;
    }

    public static int PosY(int rw)
    {
        height = (rw - 1) * 4;
        return width;
    }

    public static int NewPosition(int oldColumn,int oldRow)
    {
        posList = (oldColumn - 1) + ((oldRow - 1) * 10);
        return posList;
    }
}
