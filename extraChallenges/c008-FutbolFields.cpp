// Challenge 008: Acepta 403, En campos de fútbol
// Gonzalo Martínez

#include <iostream>

using namespace std;

int main()
{
    double cases, meters, numberc;
    
    cin >> cases;

    for(int i = 0; i < cases; i++)
    {
        cin >> meters >> numberc;
        
        if(meters / numberc >= 4050 && meters / numberc <= 10800)
        {
            cout << "SI"<< endl;
        }
        else{
            cout << "NO"<< endl;
        }
    }       
    return 0;
}
