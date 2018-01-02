// Marcos Cervantes Matamoros
// Basico 27 de diciembre

/*
Crea un programa que pregunte cuántos números va a sumar y le pida esa serie de 
números, para, a continuación, mostrar el resultado de la suma. Si se introduce 
una cantidad negativa o cero, se deberá volver a introducir tantas veces como 
sea necesario. Finalmente, se mostrarán todos los datos. Ejemplo:

Cantidad de sumandos? -2
Cantidad incorrecta
Cantidad de sumandos? 3
Sumando 1? 2
Sumando 2? -5
Sumando 3? 10,5
Su suma es 7,5
Los datos eran 2 -5 10,5
*/

using System;
public class Basico27Diciembre
{
    public static void Main()
    {
        int cantidad;
        double total = 0;
        do
        {
            Console.Write("Cantidad de sumandos? ");
            cantidad = Convert.ToInt32(Console.ReadLine());
            if (cantidad == 0 || cantidad < 0)
                Console.WriteLine("Cantidad incorrecta");
        } while (cantidad == 0 || cantidad < 0);
        double[] sumandos = new double[cantidad];
        for (int i = 0; i < sumandos.Length; i++)
        {
            Console.Write("Sumando {0}? ",i+1);
            sumandos[i] = Convert.ToDouble(Console.ReadLine());
            total += sumandos[i];
        }
        Console.WriteLine("La suma es {0}", total);
        Console.Write("Los datos eran ");
        for (int i = 0; i < sumandos.Length; i++)
        {
            Console.Write(sumandos[i] + " ");
        }
        Console.WriteLine();
    }
}
