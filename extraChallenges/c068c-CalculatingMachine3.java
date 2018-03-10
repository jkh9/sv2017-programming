/*
Problema A: Máquina de cálculo


Ejemplo de entrada
5
5 + -13
10 / 2
7 * 3
3 / 0
5 - 13

Ejemplo de salida
-8
5
21
ERROR
-8

*/

import java.util.Scanner;

public class Challenge068b
{
    public static void main(String[] args)
    {
        Scanner sc = new Scanner(System.in);

        int n = sc.nextInt();
        
        for (int i = 0; i < n; i++)
        {
            int n1 = sc.nextInt();
            String op = sc.next();
            int n2 = sc.nextInt();
            switch (op)
            {
                case "+":
                    System.out.println(n1+n2);
                    break;
                case "-":
                    System.out.println(n1-n2);
                    break;
                case "*":
                    System.out.println(n1*n2);
                    break;
                case "/":
                    if (n2 == 0)
                        System.out.println("ERROR");
                    else
                        System.out.println(n1/n2);
                    break;
            }
        }        
    }
}
