/*
Se denomina número reversible a aquél que al ser sumado a sí mismo tras 
invertir sus dígitos da como resultado un número en el que todos los dígitos 
son impares.

Entrada de ejemplo

36
904
1000
37
209
0

Salida de ejemplo

SI
SI
NO
NO
SI
*/

// Javier Saorín Vidal

using System;

public class Ch018
{
    public static void Main()
    {
        bool reversible = true;
        string line = Console.ReadLine();

        while (line != "0")
        {
            string number2Reversed = "";
            for (int j = line.Length - 1; j >= 0; j--)
                number2Reversed += line[j];

            if (number2Reversed[0] == '0')
                reversible = false;

            uint number1 = Convert.ToUInt32(line);
            uint number2 = Convert.ToUInt32(number2Reversed);
            
            uint sum = number1 + number2;
            foreach(char digit in Convert.ToString(sum))
                if (digit % 2 == 0)
                    reversible = false;

            if (reversible)
                Console.WriteLine("SI");
            else
                Console.WriteLine("NO");

            line = Console.ReadLine();
            reversible = true;
        }
    }
}
