/*
Acepta 362: ¿Es día de Navidad?
 
Example input

2
25 12
03 05

Example output

SI
NO
*/

import java.util.Scanner;

public class ChristmasDay {
    public static void main(String [] args)  {
        
        Scanner entrada = new Scanner(System.in);
        int cases = entrada.nextInt();
        
        for(int i = 0; i < cases; i++)
        {
            int day = entrada.nextInt();
            int month = entrada.nextInt();
            if ((day == 25) && (month == 12))
                System.out.println("SI");
            else
                System.out.println("NO");
        }
    }
}
