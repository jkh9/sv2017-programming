// V0.10 17-Ene-2018, Encinas & Others
//          Created class BigNumbers
// V0.13 20-Apr-2018 Nacho: Margin uses lines instead of "o"
// V0.14 20-Apr-2018 Guille, Brandon & Cases: Added decimals in big numbers

using System;

class BigNumbers
{
    static string[,,] numbers = new string[11, 5, 1]
    {
        {
            {" ** "},
            {"*  *"},
            {"*  *"},
            {"*  *"},
            {" ** "},
        },
        {
            {"*** "},
            {"  * "},
            {"  * "},
            {"  * "},
            {" ***"},
        },
        {
            {" ***"},
            {"*  *"},
            {" *  "},
            {"*   "},
            {"****"},
        },
        {
            {"*** "},
            {"   *"},
            {"*** "},
            {"   *"},
            {"*** "},
        },
        {
            {"*  *"},
            {"*  *"},
            {"****"},
            {"   *"},
            {"   *"},
        },
        {
            {"****"},
            {"*   "},
            {"****"},
            {"   *"},
            {"****"},
        },
        {
            {"****"},
            {"*   "},
            {"****"},
            {"*  *"},
            {"****"},
        },
        {
            {"****"},
            {"   *"},
            {"  * "},
            {" *  "},
            {"*   "},
        },
        {
            {" ** "},
            {"*  *"},
            {" ** "},
            {"*  *"},
            {" ** "},
        },
        {
            {"****"},
            {"*  *"},
            {"****"},
            {"   *"},
            {"****"},
        },
        {
            {"    "},
            {"    "},
            {"    "},
            {" ** "},
            {" ** "},
        },
    };

    public static void ShowAmount(string amount, int newX, int newY)
    {
        int x = newX;
        int y = newY;
        for (int i = 0; i <= 8; i++)
        {
            Console.SetCursorPosition(x - 2, y - 2 + i);
            if (i == 0 || i == 8)
            {
                Console.Write(new string('-', 40));
            }
            else
            {
                Console.Write("|");
                Console.Write(new string(' ', 40));
                Console.Write("|");
            }
        }
        foreach (char item in amount)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.SetCursorPosition(x, y + i);
                if (item == ',')
                {
                    Console.Write(numbers[10, i, 0]);
                }
                else
                {
                    Console.Write(numbers[Convert.ToInt32(Convert.ToString(item)), i, 0]);
                }
            }
            x += 5;
        }
    }

}
