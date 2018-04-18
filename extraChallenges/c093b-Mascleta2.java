// Challenge 093: Mascleta
// Max and min in a series 

// Input sample
// 3
// 5 10 1 22 33 4
// 1 10
// 3 1 1 2
// 
// Output sample
// 33 1
// 10 10
// 2 1

// package javachallenges;

import java.util.Scanner;

/**
 *
 * @author Moisex
 */
public class EjerciciosClase
{
    public static void main(String[] args)
    {
        Scanner sc = new Scanner(System.in);
        int casos = sc.nextInt();
        sc.nextLine();
        
        for (int caso = 0; caso < casos; caso++)
        {
            int numbersAmount = sc.nextInt();
            int[] numbers = new int[numbersAmount];
            
            for (int number = 0; number < numbersAmount; number++)
            {
                numbers[number] = sc.nextInt();
            }
            
            int mayor=numbers[0];
            int menor=numbers[0];
            
            for (int i = 0; i < numbersAmount; i++)
            {
                mayor = numbers[i] > mayor ? numbers[i] : mayor;
                menor = numbers[i] < menor ? numbers[i] : menor;
            }
            
            System.out.println(mayor+" "+menor);
        }
    }
}
