//Daniel MIquel SIrera
//Javier Herreros
//Lucia Navarro 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex165
{
    class Program
    {
        static void Main()
        {
            const int BLOCK = 3;
            const int FILA = 3;
            int[,] table = new int[BLOCK,FILA];
            byte coord1, coord2,count;
            char symbol;
            count = 1;

            if (count % 2 == 0)
                symbol = 'X';
            else
                symbol = 'O';
            count++;

            Console.Write("Enter coord 1:");
            coord1 = Convert.ToByte(Console.ReadLine());
            Console.Write("Enter coord 2:");
            coord2 = Convert.ToByte(Console.ReadLine());

            for (int i = 0; i < coord1; i++)
            {
                Console.WriteLine();
            }
            for(int i = 0; i < coord2; i++)
            {
                Console.Write(" ");
            }
            Console.Write("X");
            Console.WriteLine();
        }
    }
}
