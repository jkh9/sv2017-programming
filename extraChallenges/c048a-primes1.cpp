// Olimpiada informática UA 2017
// Problema 1: Calculador de números primos (3 puntos)
// 
// Un número primo es un número entero que sólo es divisible por sí mismo y por 1. 
// Es decir, si no hay ningún número entre 1 (sin incluir a éste) y n que pueda 
// dividir a n sin resto, entonces n es primo.
// 
// Se pide realizar un programa que calcule los números primos que se encuentran 
// en el rango desde 2 hasta m. El programa debe pedir un número máximo m e 
// imprimir todos los primos en el rango indicado.
// 
// Ejemplo de funcionamiento:
// Introduzca el valor m: 21 
// Números primos: 2 3 5 7 11 13 17 19

//Almudena Lopez Sanchez

#include<iostream>
using namespace std;

int main()
{
    int max;
    cout << "Introduzca el valor de m: ";
    cin >> max;
    int nums;
    int div;
    cout << "Numeros primos:";
    for(int i = 2; i < max; i++)
    {
        div = i -1;
        nums = 0;
        while(nums < 1 && div > 1)
        {
            if(i % div == 0)
                nums++;
            div--;
        }
        if(nums == 0)
            cout << " " << i;
    }
    cout << endl;
}
