//Almudena Lopez Sanchez

/*
Aprendiendo el código Morse

Letra   Código      Letra   Código
A   .-          N   -.
B   -...        O   ---
C   -.-.        P   .--.
D   -..         Q   --.-
E   .           R   .-.
F   ..-.        S   ...
G   --.         T   -
H   ....        U   ..-
I   ..          V   ...-
J   .---        W   .--
K   -.-         X   -..-
L   .-..        Y   -.--
M   --          Z   --..


La palabra elegida para cada letra debe comenzar por esa letra y ser tal que si 
cada vocal 'o' se sustituye por una raya, y el resto de vocales por un punto, 
el resultado final sea la codificación de la letra en cuestión:

Letra   Palabra de referencia   Código
A   Arco    .-
B   Bogavante   -...
C   Corazones   -.-.

Entrada de ejemplo
Arco
Corazones
ARBOLES

Salida de ejemplo 
Arco OK
Corazones OK
ARBOLES X
*/

 
import java.util.Scanner;

public class Challenge211
{
    public static void main(String [] args)  
    {
        Scanner entrada = new Scanner(System.in);
        String word = entrada.nextLine();
        while ((word != null) && (! word.equals("")))
        {
            String codigo = "";
            char[] letritas = word.toLowerCase().toCharArray();
            for(char letter : letritas)
            {
                if(letter == 'o')
                    codigo += "-";
                else if (letter == 'a' || letter == 'e' || 
                    letter == 'i' || letter == 'u')
                        codigo += ".";
            }
            System.out.print(word + " ");
            switch(letritas[0])
            {
                case 'a': System.out.println(codigo.equals(".-") ? "OK" : "X");
                    break;
                case 'b': System.out.println(codigo.equals("-...") ? "OK" : "X");
                    break;
                case 'c': System.out.println(codigo.equals("-.-.") ? "OK" : "X");
                    break;
                case 'd': System.out.println(codigo.equals("-..") ? "OK" : "X");
                    break;
                case 'e': System.out.println(codigo.equals(".") ? "OK" : "X");
                    break;
                case 'f': System.out.println(codigo.equals("..-.") ? "OK" : "X");
                    break;
                case 'g': System.out.println(codigo.equals("--.") ? "OK" : "X");
                    break;
                case 'h': System.out.println(codigo.equals("....") ? "OK" : "X");
                    break;
                case 'i': System.out.println(codigo.equals("..") ? "OK" : "X");
                    break;
                case 'j': System.out.println(codigo.equals(".---") ? "OK" : "X");
                    break;
                case 'k': System.out.println(codigo.equals("-.-") ? "OK" : "X");
                    break;
                case 'l': System.out.println(codigo.equals(".-..") ? "OK" : "X");
                    break;
                case 'm': System.out.println(codigo.equals("--") ? "OK" : "X");
                    break;
                case 'n': System.out.println(codigo.equals("-.") ? "OK" : "X");
                    break;
                case 'o': System.out.println(codigo.equals("---") ? "OK" : "X");
                    break;
                case 'p': System.out.println(codigo.equals(".--.") ? "OK" : "X");
                    break;
                case 'q': System.out.println(codigo.equals("--.-") ? "OK" : "X");
                    break;
                case 'r': System.out.println(codigo.equals(".-.") ? "OK" : "X");
                    break;
                case 's': System.out.println(codigo.equals("...") ? "OK" : "X");
                    break;
                case 't': System.out.println(codigo.equals("-") ? "OK" : "X");
                    break;
                case 'u': System.out.println(codigo.equals("..-") ? "OK" : "X");
                    break;
                case 'v': System.out.println(codigo.equals("...-") ? "OK" : "X");
                    break;
                case 'w': System.out.println(codigo.equals(".--") ? "OK" : "X");
                    break;
                case 'y': System.out.println(codigo.equals("-.--") ? "OK" : "X");
                    break;
                case 'z': System.out.println(codigo.equals("--..") ? "OK" : "X");
                    break;
                // Esto no se si es necesario...
                // default: System.out.println("Error");
                //    break;
            }
            word = entrada.nextLine();
        }
    }
}
