// Challenge 055 : I'm getting married

// Sample input
// 4
// 100 200 100 200
// 2
// 50 25
// 0
// 
// Sample output
// 600
// 75

//Daniel Miquel Sirera

#include <iostream>
using namespace std;

int main()
{
    int casos;
    int suma;
    int datos;
    
    do
    {
        cin >> casos;
        if(datos>0)
        {
            suma = 0;
            for(int i = 0; i < casos ; i++)
            {
                cin >> datos;
                suma += datos;
            }
            cout << suma << endl;
        }
    } while(casos > 0);
    
    return 0;
}
