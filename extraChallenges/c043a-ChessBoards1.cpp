/*
Chess boards
(drawing a 8x8 chess board. Each tile must have a certain size and char)

Entrada de ejemplo
2 #
0

Salida de ejemplo
|----------------|
|  ##  ##  ##  ##|
|  ##  ##  ##  ##|
|##  ##  ##  ##  |
|##  ##  ##  ##  |
|  ##  ##  ##  ##|
|  ##  ##  ##  ##|
|##  ##  ##  ##  |
|##  ##  ##  ##  |
|  ##  ##  ##  ##|
|  ##  ##  ##  ##|
|##  ##  ##  ##  |
|##  ##  ##  ##  |
|  ##  ##  ##  ##|
|  ##  ##  ##  ##|
|##  ##  ##  ##  |
|##  ##  ##  ##  |
|----------------|
*/

//Almudena Lopez Sanchez

#include<iostream>
using namespace std;
int main()
{
    int num;
    char symbol;
    int size;
    do
    {
        cin >> num;
        if ( num != 0)
        {
            size = 8;
            cin >> symbol;
            
            // Preparación de las filas pares e impares
            string par = "";
            string impar = "";
            for(int count = 0 ; count < 8; count++)
            {
                if( count % 2 == 0)
                {
                    for(int p = 0; p < num; p++)
                    {
                        par = par + " ";
                        impar = impar + symbol;
                    }   
                }
                else
                {
                    for(int p = 0; p < num; p++)
                    {
                        par = par + symbol;
                        impar = impar + " ";
                    }
                }
            }
            
            // Preparación de los guiones
            string guiones = "|";
            for(int guion = 0; guion < size*num; guion++)
            {
                guiones = guiones +"-";
            }
            guiones = guiones + "|";
            
            // Y escritura del tablero
            cout << guiones << endl;
            for(int i = 0; i < size; i++)
            {
                if( i % 2 == 0)
                {
                    for(int line = 0; line < num; line++)
                        cout << "|"+par+"|"<< endl;
                }
                else
                {
                    for(int line = 0; line < num; line++)
                        cout << "|"+impar+"|"<< endl;
                }
            }
            cout << guiones << endl;
        }
    }
    while(num != 0);
}
