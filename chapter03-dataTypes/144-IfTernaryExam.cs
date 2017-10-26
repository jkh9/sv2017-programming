/*
Crea un programa en C# que asigne a la variable "calificacion" (string) el 
valor "suspenso" si la variable numérica "nota" tiene un valor inferior a 5, 
"aprobado" si está entre 5 y 7, ambos incluidos, o "excelente" si es superior a 
7. Hazlo de dos formas: primero con "if" y luego usando el operador condicional 
o ternario (?)
*/

// Pedro Luis Coloma

using System;

public class WorkingTime
{    
    public static void Main()
    {
        byte nota;
        string calificacion;
        Console.Write("Nota: ");
        nota = Convert.ToByte(Console.ReadLine());
        
        if (nota < 5)
            calificacion = "suspenso";
        else if (nota <=7)
            calificacion = "aprobado";
        else
            calificacion = "excelente";
        Console.WriteLine(calificacion);
        
        calificacion = nota < 5? "suspenso" : 
            nota <=7? "aprobado": "excelente";
        Console.WriteLine(calificacion);
    }
}
