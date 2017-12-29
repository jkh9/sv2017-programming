//Almudena Lopez Sanchez
//Challenge 041 - Festivolandia

/*
Los días pares de los meses pares son festivos, y los días impares de los meses 
impares también. El único día impar que es festivo en un mes par es el día de 
navidad, el 25 de diciembre. El resto de días son laborables.

Ejemplo de entrada
6
8 7
25 12
11 1
2 2
14 2
3 2

Ejemplo de salida
LABORABLE
FESTIVO
FESTIVO
FESTIVO
FESTIVO
LABORABLE
*/

import java.util.Scanner;

public class Festivolandia
{
    public static void main(String [] args)  
    {
        Scanner entrada = new Scanner(System.in);
        int casos = entrada.nextInt();
        int dia, mes;
        for(int i = 0; i < casos; i++)
        {
            dia = entrada.nextInt();
            mes = entrada.nextInt();
            
            if ((mes == 12 && dia == 25)
                    ||(mes % 2 == dia % 2))
                System.out.println("FESTIVO");
            else
                System.out.println("LABORABLE");
        }
    }
}
