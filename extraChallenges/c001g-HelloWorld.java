/*
Challenge 001:

Crea un programa que reciba un entero de la entrada estándar y escriba 
"Hola mundo." tantas veces como indique ese número.

Entrada de ejemplo

3

Salida de ejemplo

Hola mundo.
Hola mundo.
Hola mundo.
*/

// Chris Lund

public class HelloWorld
{
    public static void main(String[] args)
    {
        int n;

        n = Integer.parseInt( System.console().readLine() );

        for (int i= 0; i < n; i++)
        {
            System.out.println("Hola mundo.");
        }
    }
}
