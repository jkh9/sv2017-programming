//Marcos Cervantes Matamoros
//Basico 30 de diciembre
/*
Crea un programa que pida al usuario 5 marcas, modelos y potencias de coches, 
que se deberán guardar en un array de struct. Después mostrará la marca, modelo
y potencia del coche más potente. */
using System;

struct Coches
{
    public string marca;
    public string modelo;
    public double potencia;
}

public class Basico30Diciembre
{
    public static void Main()
    {
        int max = 0;
        double compara = 0;
        Coches[] coche = new Coches[5];
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Coche numero {0}", i +1);
            Console.Write("Introduce la marca del coche numero {0}: ", i +1);
            coche[i].marca = Console.ReadLine();
            Console.Write("Introduce el modelo del coche numero {0}: ", i + 1);
            coche[i].modelo = Console.ReadLine();
            Console.Write("Introduce la marca del coche numero {0}: ", i + 1);
            coche[i].potencia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if (i == 0)
                compara = coche[i].potencia;
            if (coche[i].potencia >= compara)
            {
                max = i;
                compara = coche[i].potencia;
            }
        }
        Console.WriteLine("Coche mas potente");
        Console.WriteLine("Marca: {0}",coche[max].marca);
        Console.WriteLine("Modelo: {0}", coche[max].modelo);
        Console.WriteLine("Potencia: {0}", coche[max].potencia);
    }
}
