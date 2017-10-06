//Daniel Miquel Sirera
//Marks with If

using System;

public class Ex72
{
    public static void Main()
    {
        int mark;
        
        Console.Write("Mark: ");
        mark = Convert.ToInt32(Console.ReadLine());
        
        if((mark >= 0)  && (mark <= 4))
            Console.WriteLine("Suspenso");
        else if(mark == 5)
            Console.WriteLine("Suficiente");
        else if(mark == 6)
            Console.WriteLine("Bien");
        else if((mark == 7) || (mark == 8))
            Console.WriteLine("Notable");
        else if((mark == 9) || (mark == 10))
            Console.WriteLine("Sobresaliente");
        else
            Console.WriteLine("Error");
    }
}
