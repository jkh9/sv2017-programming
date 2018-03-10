package javachallenges;
import java.util.Scanner;

/**
 *
 * @author Moises
 */
public class ChallengeA
{
    public static void main(String[] args)
    {
        Scanner sc = new Scanner(System.in);
        int times = sc.nextInt();
        sc.nextLine();
        
        for (int i = 0; i < times; i++)
        {
            String line = sc.nextLine();
            String[] parts= line.split(" ");
            
            int n1 = Integer.parseInt(parts[0]);
            int n2 = Integer.parseInt(parts[2]);
            
            switch(parts[1])
            {
                case "+":
                    System.out.println(n1 + n2);
                    break;
                case "-":
                    System.out.println(n1 - n2);
                    break;
                case "/":
                    if(n2 == 0)
                    {
                        System.out.println("ERROR");
                    }
                    else
                    {
                        System.out.println(n1 / n2);
                    }
                    break;
                case "*":
                    System.out.println(n1 * n2);
                    break;
            }
        }
    }
}
