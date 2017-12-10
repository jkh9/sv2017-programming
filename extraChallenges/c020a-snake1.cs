//Almudena Lopez Sanchez
//Challenge 20 Snake

/*
Ejemplo de entrada

4
3 3
3 4
5 3
9 9

Ejemplo de salida

Caso 1
###
..#
###
Caso 2
####
...#
####
Caso 3
###
..#
###
#..
###
Caso 4
#########
........#
#########
#........
#########
........#
#########
#........
#########
*/

using System;
public class Snake
{
    public static void Main()
    {
        int casos = Convert.ToInt32(Console.ReadLine());
        string lineaUsuario;
        int numLineas;
        int numCaracteres;
        bool caracterDelante;

        for (int contador = 1; contador <= casos; contador++)
        {
            lineaUsuario = Console.ReadLine();

            numLineas = Convert.ToInt32(lineaUsuario.Substring(0, 1));
            numCaracteres = Convert.ToInt32(lineaUsuario.Substring(2, 1));
            caracterDelante = false;

            Console.WriteLine("Caso {0}", contador);
            for(int linea = 1; linea <= numLineas; linea++)
            {
                if (linea % 2 != 0)
                    LineasImpares(numCaracteres);
                else
                {
                    LineasPares(numCaracteres,caracterDelante);
                    CambiarCaracterDelante(ref caracterDelante);
                }
            }
        }
    }

    //No hace falta hacer funciones pero he hecho unas cuantas para practicar
    public static void LineasImpares(int numCaracteres)
    {
        string caracter = new String('#', numCaracteres);
        Console.WriteLine(caracter);
    }

    public static void LineasPares(int numCaracteres, bool caracterDelante)
    {
        string puntos = new string('.', numCaracteres - 1);

        if (caracterDelante)
            Console.WriteLine("#" + puntos);
        else
            Console.WriteLine(puntos + "#");
    }
    public static void CambiarCaracterDelante(ref bool caracterDelante)
    {
        if (caracterDelante)
            caracterDelante = false;
        else
            caracterDelante = true;
    }
}
