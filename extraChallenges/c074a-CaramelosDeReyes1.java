/// By Don Coloma

import java.util.Scanner;

public class Reto426 {
    
    public static void main (String[] args) {
        int children;
        int total;
        int x;
        Scanner sc = new Scanner(System.in);
        
        do
        {
            total = 0;
            children = 0;
            do
            {
                x = sc.nextInt();
                if (x != 0)
                {
                    total +=x;
                    children++;
                }
                
            } while (x != 0);
            
            if (children != 0)
            {
                if (total % children == 0)
                    System.out.println("SI");
                else
                    System.out.println("NO");
            }
        
        } while (children != 0);
    }
}

