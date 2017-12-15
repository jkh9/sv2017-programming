import java.util.Scanner;

public class Fitness {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int calorias = 0;
        int comidas = 0;
        int calinge = 0;
        int total = 0;
        int entrenamientos = 0;
        do {
            calorias = sc.nextInt();
            if ( calorias == 0 ) {
                break;
            }
            comidas = sc.nextInt();
            for (int i = 0; i < comidas; i++) {
                calinge = sc.nextInt();
                total += calinge;
            }
            entrenamientos = total / calorias;
            if ( total % calorias != 0 ) {
                entrenamientos++;
            }
            System.out.println(entrenamientos);
            calorias = 0;
            comidas = 0;
            calinge = 0;
            total = 0;
            entrenamientos = 0;
        } while ( true );
        
    }
    
}
