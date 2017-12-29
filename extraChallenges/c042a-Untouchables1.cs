/*
6
4 4
XXXX
XXXX
XXXX
XXXX
3 3
XXX
XFX
XXX
3 3
XXX
FXX
XXX
4 3
XXXX
FXFX
XXXX
6 6
XXXXXX
XFXXFX
XXXXXX
XFXFXX
XXXXXX
XXXXXX
6 6
XXXXXX
XFXXFX
XXXXXX
XFFXXX
XXXXXX
XXXXXX

Ejemplo de salida
INVALIDA
VALIDA
INVALIDA
INVALIDA
VALIDA
INVALIDA
*/

// Pedro Luis Coloma, correcciones por Nacho

using System;
public class ch42
{
    public static void Main ()
    {
        byte cases = Convert.ToByte(Console.ReadLine());       
        do
        {
            string[] dato = Console.ReadLine().Split(); // La entrada era incorrecta
            byte columnsN = Convert.ToByte(dato[0]);
            byte linesM = Convert.ToByte(dato[1]);
            char[,] pos = new char[columnsN,linesM];
            bool valida = true;
            
            for (int m = 0; m < linesM; m++)
            {
                string linea = Console.ReadLine();  // La entrada era incorrecta
                for (int n = 0; n < columnsN; n++)
                {
                    pos[n,m] = linea[n];
                }
            }
            
            // Reviso las posiciones interiores
            for (int n = 1; n < columnsN-1; n++)
            {
                for (int m = 1; m < linesM-1; m++)
                {
                    if (pos[n,m] == 'F')
                    {
                        // Aquí había un error: no se puede hacer 
                        // valida = true en cada pasada
                        
                        if ((pos[n-1,m] == 'F') || (pos[n,m-1] == 'F') ||
                            (pos[n+1,m] == 'F') || (pos[n,m+1] == 'F') ||
                            (pos[n+1,m+1] == 'F') || (pos[n-1,m-1] == 'F') || 
                            (pos[n+1,m-1] == 'F') || (pos[n-1,m+1] == 'F'))
                        {
                            valida = false; //si tiene algo cerca no valido
                        }   
                    }  
                }
            }
            
            // Este fragmento faltaba;
            // Reviso las posiciones de los bordes, que no se pueden ocupar
            for (int n = 0; n < columnsN; n++)
            {
                for (int m = 0; m < linesM; m++)
                {
                    if  ((n==0) || (n==columnsN) ||
                            (m==0) || (n==linesM))
                        if (pos[n,m] == 'F')
                            valida = false; //si tiene algo cerca no valido
                }
            }
            
            // Este fragmento también faltaba;
            // Debe haber al menos una figurita
            int cantidadFiguritas = 0;
            for (int n = 0; n < columnsN; n++)
            {
                for (int m = 0; m < linesM; m++)
                {
                    if (pos[n,m] == 'F')
                        cantidadFiguritas++;
                }
            }
            if (cantidadFiguritas == 0)
                valida = false;
            
            
            if (valida)
            {
                Console.WriteLine("VALIDA");
            }
            else
            {
                Console.WriteLine("INVALIDA"); 
            }
            cases--;            
        } while (cases>0);
    }
}
