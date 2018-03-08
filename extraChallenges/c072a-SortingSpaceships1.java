package javachallenges;

import java.util.ArrayList;
import java.util.Collections;
import java.util.List;
import java.util.Scanner;

/**
 *
 * @author jkh9L
 */
public class ChallengeE
{
    public static void main(String[] args)
    {
        Scanner sc = new Scanner(System.in);
        int times = sc.nextInt();
        sc.nextLine();
        List<Nave> naves;
        List<Nave> naves2;
        int cont = 1;
        
        for (int i = 0; i < times; i++)
        {
            naves = new ArrayList<>();
            naves2 = new ArrayList<>();
            
            int oxigenoMinimo = sc.nextInt();
            int numeroNaves = sc.nextInt();
            
            for (int j = 0; j < numeroNaves; j++)
            {
                Nave a = new Nave();
                a.oxigeno = sc.nextInt();
                a.peso = sc.nextInt();
                a.superaLimite = a.oxigeno >= oxigenoMinimo;
                if (a.superaLimite)
                {
                    naves.add(a);
                }
                else
                {
                    naves2.add(a);
                }
            }
            if (naves.size() > 1)
            {
                Collections.sort(naves);
            }
            if (naves2.size() > 1)
            {
                Collections.sort(naves2);
            }
            System.out.println("Caso "+cont+":");

            for (int j = 0; j < naves.size(); j++)
            {
                System.out.println(naves.get(j).oxigeno+" "+naves.get(j).peso);
            }
            
            for (int j = 0; j < naves2.size(); j++)
            {
                System.out.println(naves2.get(j).oxigeno+" "+naves2.get(j).peso);
            }
            cont++;
        }
        
    }
}

class Nave implements Comparable
{
    int oxigeno;
    int peso;
    boolean superaLimite;
    
    @Override
    public int compareTo(Object o)
    {
        Nave otherNave = (Nave)o;
        
        if (this.peso < otherNave.peso)
        return -1;
        else if (this.peso > otherNave.peso)
        return +1;
        else if (this.peso == otherNave.peso)
        {
            if (this.oxigeno > otherNave.oxigeno)
            return -1;
            else if (this.oxigeno < otherNave.oxigeno)
            return +1;
        }
        return 0;
    }

}
