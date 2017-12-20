/*

Acepta 427: Yo soy tu...

Sample input
 
4
C-3PO
creador
Luke
padre
Princesa
Principe
Luke
Padre

Sample output

C-3PO, yo soy tu creador
TOP SECRET
Princesa, yo soy tu Principe
Luke, yo soy tu Padre

*/

// Jose Vilaplana

#include <iostream>

using namespace std;

int main()
{
    int prueba;
    string text , text2;
    cin >> prueba;
    
    while(prueba > 0)
    {
        string finaltext = "";
        cin >> text;
        cin >> text2;
        if(text == "Luke" && text2 == "padre")
        {
            cout << "TOP SECRET" << endl;
        }
        else
        {
            finaltext += text + ", yo soy tu " + text2;
            cout << finaltext << endl;
        }
        prueba--;
    }
    return 0;
}
