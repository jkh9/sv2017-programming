// Almudena Lopez Sanchez
// Challenge 013 - La lotería de la peña Atlética (cantidad de pares)

// Entrada de ejemplo
// 1
// 10
// 1 2 3 4 5 6 7 8 9 10
// 
// Salida de ejemplo
// 5

using System;
public class Challenge13
{
    public static void Main()
    {
        int cont = Convert.ToInt32(Console.ReadLine());
        int linea1;
        string linea2;
        int numerosComprar;
        
        while(cont != 0)
        {
            numerosComprar = 0;
            linea1 = Convert.ToInt32(Console.ReadLine());
            linea2 = Console.ReadLine();
            string[] numeritos = linea2.Split();
            //con un foreach no utilizamos la linea 1 que nos da el usuario
            foreach (string numero in numeritos)
            {
                if(Convert.ToInt32(numero) % 2 == 0)
                {
                    numerosComprar++;
                }
            }
            Console.WriteLine(numerosComprar);
            cont--;
            /*
             * Otra forma para usar la linea 1
             * En vez de foreach:
             * 
             * for(int num = 0; num < linea1; num--)
             * {
             *      if(numeritos[num] % 2 == 0)
             *          numerosComprar++;
             * }
             * 
             */
        }
    }
}

