package javachallenges;

import java.util.Scanner;

/**
 *
 * @author jkh9L
 */
public class ChallengeB
{
    public static void main(String[] args)
    {
        Scanner sc = new Scanner(System.in);
        
        int times = sc.nextInt();
        sc.nextLine();

        for (int i = 0; i < times; i++) 
        {
            String conso = "";
            boolean correcto = true;
            String text = sc.nextLine().toLowerCase();
            
            for (int j = 0; j < text.length(); j++) 
            {
                String letra = text.substring(j,(j+1));
                if(!letra.equals("a") && !letra.equals("e") && !letra.equals("i")
                        && !letra.equals("o") && !letra.equals("u"))
                {
                    conso += letra;
                }
            }
            
            for (int j = 0; j < conso.length()-1; j++)
            {
                if (conso.charAt(j) > conso.charAt(j+1))
                {
                    correcto = false;
                    break;
                }
            }

            if(correcto)
                System.out.println("ERROR");
            else
               System.out.println("OK"); 
        }
    }
}
