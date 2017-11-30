//Victor Tebar

using System;

public class Ejer215{
    public static string Reverse(string str){
        string reversed = "";
        
        foreach(char letter in str){
            reversed = letter + reversed;
        }
        
        return reversed;
    }
    
    public static void Main(){
        string x = Reverse( "Hola" );
        
        Console.WriteLine(x);
        Console.WriteLine(Reverse("Qué tal?"));
    }
}
