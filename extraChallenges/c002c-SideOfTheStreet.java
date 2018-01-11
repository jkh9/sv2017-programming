/*
Challenge 002: Side Of The Street

Answer = "DERECHA" if input is even, IZQUIERDA if it is ODD
0 to end
*/

import java.util.Scanner;

public class SideOfTheSreet
{
    public static void main(String[] args)
    {
        int n;

        Scanner sc = new Scanner(System.in);
        n = sc.nextInt();

        while ( n != 0 )
        {
            if (n % 2 == 0)
                System.out.println("DERECHA.");
            else
                System.out.println("IZQUIERDA.");
            n = sc.nextInt();
        }
    }
}
