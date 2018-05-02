//Moisés Encinas, Marcos Cervantes, Jose Vilaplana
// V1: Approx 4.050 bytes
using System;
using System.Text;

class FourInARow
{
    static void Main(string[] args)
    {
        string[] map =
        {
            "| | | | | | | |",
            "---------------",
            "| | | | | | | |",
            "---------------",
            "| | | | | | | |",
            "---------------",
            "| | | | | | | |",
            "---------------",
            "| | | | | | | |",
            "---------------",
            "| | | | | | | |",
            "---------------",
            "| | | | | | | |",
            "---------------",
        };

        bool turn = true;
        byte position = 0;

        WriteMap(map);

        do
        {
            //1.-Check user input
            position = GetNumber();

            //2.-Check collisions
            Position(position, ref map, turn);

            //3.-Write map
            WriteMap(map);

            //4.-Cambio de turno
            turn = !turn;

        } while (!WonX(map) && !WonY(map));

        if (WonX(map))
        {
            Console.WriteLine("Won the X");
        }
        else
        {
            Console.WriteLine("Won the O");
        }
    }

    public static void WriteMap(string[] map)
    {
        Console.Clear();
        for (int i = 0; i < map.Length; i++)
        {
            Console.WriteLine(map[i]);
        }
    }

    public static byte GetNumber()
    {
        ConsoleKeyInfo number;
        number = Console.ReadKey(false);
        switch (number.Key)
        {
            case ConsoleKey.D1: return 1;
            case ConsoleKey.D2: return 3;
            case ConsoleKey.D3: return 5;
            case ConsoleKey.D4: return 7;
            case ConsoleKey.D5: return 9;
            case ConsoleKey.D6: return 11;
            case ConsoleKey.D7: return 13;
            default: return 0; //Incase the input its not correct, do nothing.
        }
    }

    public static bool WonX(string[] map)
    {
        for (int i = 0; i < map.Length; i++)
        {
            if (map[i].Contains("x|x|x|x"))
            {
                return true;
            }
        }

        map = Reverse(map);

        for (int i = 0; i < map.Length; i++)
        {
            if (map[i].Contains("x-x-x-x"))
            {
                return true;
            }
        }

        return false;
    }

    public static bool WonY(string[] map)
    {
        for (int i = 0; i < map.Length; i++)
        {
            if (map[i].Contains("o|o|o|o"))
            {
                return true;
            }
        }

        map = Reverse(map);

        for (int i = 0; i < map.Length; i++)
        {
            if (map[i].Contains("o-o-o-o"))
            {
                return true;
            }
        }

        return false;
    }

    public static string[] Reverse(string[] map)
    {
        string[] newMap = new string[map[0].Length];

        for (int i = 0; i < map[0].Length; i++)
        {
            string line = "";
            for (int a = 0; a < map.Length; a++)
            {
                line += map[a][i];
            }
            newMap[i] = line;
        }

        return newMap;
    }

    public static void Position(byte position, ref string[] map, bool turn)
    {
        for (int i = 12; i >= 0; i -= 2)
        {
            if (map[i][position] == ' ')
            //Position x2 cause the ' | ' are in the middle
            {
                string aux = map[i];
                StringBuilder modificableString = new StringBuilder(aux);
                if (turn == true)
                    modificableString[position] = 'o';
                else
                    modificableString[position] = 'x';
                aux = modificableString.ToString();
                map[i] = aux;
                break;
            }
        }
    }
}
