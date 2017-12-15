import java.util.Scanner;

public class Challenge364
{
    public static void main(String [] args)  
    {
        Scanner entrada = new Scanner(System.in);
        
        String text = "";
        
        char letra;
        do
        {
            text = entrada.nextLine();
            
            if (!text.equals("FIN"))
            {
                for(int i = 0; i < text.length(); i++)
                {
                    letra = text.charAt(i);
                    if(letra == 'Z')
                    {
                        System.out.print("A");
                    }
                    else if(letra == ' ')
                    {
                        System.out.print(" ");
                    }
                    else
                    {
                        letra++;
                        System.out.print(letra);
                    }
                }
                System.out.println();
            }
        }
        while(!text.equals("FIN"));
    }
}
