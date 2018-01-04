/*
Olimpiada Informatica UA 2017

Problema 2: Comprobador de ISBN (3 puntos)

Un ISBN es un código de 10 dígitos que identifica de forma única a un libro. 
Los primeros 9 dígitos representan el libro y el último dígito se utiliza para 
comprobar que el ISBN es correcto.

Para comprobar que un ISBN es correcto se debe multiplicar el primer dígito por 
10, el segundo por 9, el tercero por 8 y así sucesivamente hasta que el último 
dígito se multiplica por 1. Si el número resultante es un múltiplo de 11, el 
código ISBN es válido. Es posible que al número resultante haya que sumarle 10 
para que el ISBN sea válido. En ese caso se usa la letra x.

Por ejemplo, 0201103311 es un ISBN válido porque:

10*0 + 9*2 + 8*0 + 7*1 + 6*1 + 5*0 + 4*3 + 3*3 + 2*1 + 1*1 = 55

y 55 es múltiplo de 11 (55 = 11*5).

Otro ejemplo de número ISBN válido es 156881111x:

10*1 + 9*5 + 8*6 + 7*8 + 6*8 + 5*1 + 4*1 + 3*1 + 2*1 + 1*10 = 231 y 231 es 
múltiplo de 11 (231 = 11*21).

Escribe un programa que compruebe si un ISBN es válido.

Ejemplo de funcionamiento

Introduzca ISBN: 0201103311 
El ISBN es válido

Introduzca ISBN: 0201103411 
El ISBN no es válido

Añade una opción al programa anterior que permita reparar números ISBN cuando 
detecte que le falta un dígito (marcado con el símbolo ?). En ese caso, el 
programa debe imprimir el valor correcto del dígito que falta.

Ejemplo de funcionamiento

Introduzca ISBN: 15688?111X 
El dígito que falta es 1
*/

//Almudena Lopez Sanchez
#include<iostream>
using namespace std;
int main()
{
    cout << "Introduzca ISBN: ";
    string isbn;
    cin >> isbn;
    
    int sum = 0;
    int count = 0;
    int iU;
    bool digitU = false;
    for(int i = 10; i > 1; i--)
    {
        if (isbn[count] == '?')
        {
            iU = i;
            digitU = true;
        }
        else
        {
            int num = isbn[count]-48;
            sum += (num * i);
            count++;
        }
        
    }
    if (isbn[9] == 'x' || isbn[9] == 'X')
        sum += 10;
    else
    {
        int num = isbn[count]-48;
        sum += (num * 1);
    }
    
    //Cuando falta algun numero...
    if ( digitU )
    {
        int fixedSum = sum;
        while (fixedSum % 11 != 0)
        {
            fixedSum++;
        }
        int num = ((fixedSum -sum) / iU );
        cout << "El digito que falta es " << num << endl;
    }
    else
    {
        if(sum % 11 == 0)
            cout << "El ISBN es valido" << endl;
        else
            cout << "El ISBN no es valido" << endl;
    }
    
}
