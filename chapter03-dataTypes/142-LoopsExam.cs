/*
Crea un ÚNICO programa en C# que muestre en pantalla los números múltiplos de 7 
que hay entre del 40 y -40 (descendiendo), ambos incluidos, excepto el 14, 
todos ellos en una misma línea y separados por un espacio en blanco, avanzando 
de línea tras escribir todos ellos. Lo debes hacer de cuatro formas distintas 
(ninguna de ellas debe emplear "break")

Usando "for" que cuente de 7 en 7

Usando "for" que cuente de 1 en 1

Usando "do..while"

Usando "while".
*/

//Victor Tebar
//

using System;

public class Ejer142{
    public static void Main(){
        int count;
        
        // "for" que cuente de 7 en 7
        for(int i=35;i>-40;i -= 7)
            if (i != 14)
                Console.Write(i + " ");
            
        Console.WriteLine();
        
        // "for" que cuente de 1 en 1
        for(int i=40;i>=-40;i--)
        {
            if ((i%7 == 0) && (i != 14))
                Console.Write(i + " ");
        }
        
        Console.WriteLine();
        
        // "do..while"
        count = 35;
        do
        {
            if (i != 14)
                Console.Write(count + " ");
            count -= 7;
        }
        while(count > -40);
        
        Console.WriteLine();
        
        // "while"
        count = 35;       
        while(count > -40)
        {
            if (i != 14)
                Console.Write(count + " ");
            count -= 7;
        }
    }
}
