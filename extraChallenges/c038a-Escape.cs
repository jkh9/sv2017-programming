// Escapando de las fuerzas imperiales
// Nacho

/*
Entrada de ejemplo

2 2
SF
..
2 3
S*F
*..
3 3
.S.
**.
F..
5 5
.**..
S....
****.
*F**. 
*....
5 5
S....
.**..
****.
*F**. 
*.*..

Salida de ejemplo
 
SI
NO
SI
SI
NO
*/

//#define debugging

using System;

public class TreasureSearch
{
    public static void Main()
    {
        int startX=0, startY = 0;
        string size = Console.ReadLine();
        while ((size != null) && (size != ""))
        {
            // Leo tamaño
            string[] widthHeight = size.Split();
            int height = Convert.ToInt32(widthHeight[0]);
            int width = Convert.ToInt32(widthHeight[1]);

            // Leo datos del "laberinto"
            char[][] map = new char[height][];
            for (int row = 0; row < height; row++)
            {
                string line = Console.ReadLine();
                map[row] = line.ToCharArray();
            }

            #if debugging
                Console.WriteLine();
                Display(map, width, height);
            #endif
            
            // Busco el punto de partida, para lanzar
            // la función de búsqueda
            for (int row = 0; row < height; row++)
            {
                for (int col = 0; col < width; col++)
                {
                    if (map[row][col] == 'S')
                    {
                        startX = col;
                        startY = row;
                        // Y lo marco como "no visitado"
                        map[row][col] = '.';
                    }
                }
            }

            if (IsReachable(map, width, height, startX, startY))
                Console.WriteLine("SI");
            else
                Console.WriteLine("NO");

            size = Console.ReadLine();
        }
    }

    public static void Display(char[][] map, int width, int height)
    {
        for (int row = 0; row < height; row++)
        {
            for (int col = 0; col < width; col++)
            {
                Console.Write(map[row][col]);
            }
            Console.WriteLine();
        }
    }

    public static bool IsReachable(char[][] map,
        int width, int height, int startX, int startY)
    {
        #if debugging
            Console.WriteLine("Checking if reachable...");
            Display(map, width, height);
        #endif

        if (startX < 0) return false;
        if (startY < 0) return false;
        if (startX > width - 1) return false;
        if (startY > height - 1) return false;

        if (map[startY][startX] == '*') return false; // Asteroide
        if (map[startY][startX] == 'V') return false; // Ya visitado
        if (map[startY][startX] == 'F') return true;  // Llegada

        map[startY][startX] = 'V'; // Si es visitable, marco como visitado
        // Y busco a partir de los cuatro que le rodean
        return (IsReachable(map, width, height, startX + 1, startY)
            || IsReachable(map, width, height, startX - 1, startY)
            || IsReachable(map, width, height, startX, startY + 1)
            || IsReachable(map, width, height, startX, startY - 1)
        );
    }
}
