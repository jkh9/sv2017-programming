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
        
        int cases = Integer.parseInt(entrada.nextLine());
        
        for(int i = 0; i < cases; i++)
        {
            String data = entrada.nextLine();
            if (data.equals("25 12"))
                System.out.println("SI");
            else
                System.out.println("NO");
        }
    }
}
