/*

Are going to get to the end of the month with any savings?

Entrada de ejemplo
7
100 -10
-10 -100
-10 100
100 -1000
2500 -2490
9500 -9500
-100 99

Salida de ejemplo
SI
NO
SI
NO
SI
SI
NO
*/

//Almudena Lopez Sanchez
import java.util.Scanner;

public class Challenge313
{
    public static void main(String [] args)  
    {
        Scanner entrada = new Scanner(System.in);
        int num = entrada.nextInt();
        for(int i = 0; i < num; i++)
        {
            System.out.println(entrada.nextInt() 
                + entrada.nextInt() < 0 ? "NO" : "SI");
        }
    }
}
