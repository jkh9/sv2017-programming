//Almudena Lopez Sanchez

/*
Numbers of Kaprekar:

703 is, because 703^2 = 494209, and 494 + 209 = 703
9^2 = 81, and 8 + 1 = 9.

First number can be 0 (so 1 is valid), but not the second (so 100 is not valid)

Sample input
22222
75
99
100
504
1
0

Sample output
SI
NO
SI
NO
NO
SI
*/

import java.util.Scanner;
import java.io.*;

public class Challenge115
{
    public static void main(String [] args)  
    {
        Scanner entrada = new Scanner(System.in);
        int n,num, size,part1, part2;
        do
        {
            n = entrada.nextInt();
            if( n != 0)
            {
                num = n*n;
                size = (Integer.toString(num).length()) / 2;
                
                if (size == 0)
                    part1 = 0;
                else
                {
                    if (Integer.toString(num).charAt(size-1) == '0')
                        part1 = Integer.parseInt(
                            Integer.toString(num).substring(0,(size-1)));
                    else
                        part1 = Integer.parseInt(
                            Integer.toString(num).substring(0,(size)));
                }
                part2 = Integer.parseInt(Integer.toString(num).substring(size));
                System.out.println(part1 + part2 == n ? "SI" : "NO");
            }
        }
        while(n != 0);
    }
}
