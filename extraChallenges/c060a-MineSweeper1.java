/*
 
Juanito Buscaminas

Ejemplo de entrada

4 4
*...
....
.*..
....

Ejemplo de salida

*100
2210
1*10
1110

Ejemplo de entrada

3 5
**...
.....
.*...

Ejemplo de salida

**100
33200
1*100
*/

// package challenges;
import java.util.Scanner;
/**
 *
 * @author Almudena Lopez Sanchez
 */
public class Challenge60 
{
    public static void main(String[] args)
    {
        Scanner sc = new Scanner(System.in);
        
        int h = sc.nextInt();
        int w = sc.nextInt();
        sc.nextLine();
        char[][] map = new char[h][w];
        
        for(int i = 0; i < h; i++)
        {
            String line = sc.nextLine();
            for(int j = 0; j < w; j++)
            {
                map[i][j] =line.charAt(j);
            }
        }
        
        for(int i = 0; i < h; i++)
        {
            for(int j = 0; j < w; j++)
            {
                if((map[i][j]) == '*')
                    System.out.print('*');
                else
                {
                    //supongo que esta manera es liosa pero funciona
                    //no se si se puede hacer con recursividad?
                    int count = 0;
                    if(j != 0)
                    {
                        if(map[i][j -1] == '*')
                            count++;
                        if(i != 0 && map[i-1][j-1] == '*')
                            count++;
                        if(i != (h-1)&& map[i+1][j-1] == '*')
                            count++;
                    }
                    if(j != (w -1))
                    {
                        if(map[i][j+1] == '*')
                            count++;
                        if(i != 0 && map[i-1][j+1] == '*')
                            count++;
                        if(i != (h-1) && map[i+1][j+1] == '*')
                            count++;
                    }
                    if(i != 0 && map[i-1][j] == '*')
                        count++;
                    if(i != (h-1) && map[i+1][j] == '*')
                        count++;
                    
                    System.out.print(count);
                }
            }
            System.out.println();
        }
    }
}
