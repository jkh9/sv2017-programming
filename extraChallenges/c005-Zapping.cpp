// Challenge 5: Zapping (Acepta 166)
// Moisés Encinas

#include <iostream>

using namespace std;

int main()
{
    int n1,n2;
    int total,total1=0,total2=0;
    int bign,smalln;
    
    do 
    {
        cin>>n1>>n2;
        
        if (n1 > n2)
        {
            bign = n1;
            smalln = n2;
        }
        else
        {
            bign = n2;
            smalln = n1;
        }
        
        //El numero para alante
        for (int i = smalln; i < bign; i++)
        {
            total1 = total1 + 1;
        }
        
        //El numero para atrás
        for (int i = 0; i < smalln; i++)
        {
            total2 = total2 + 1;
        }
        for (int i = 99; i > bign; i--)
        {
            total2 = total2 + 1;
        }
        
        total = total1 > total2 ? total2 : total1;
        
        if (n1 != 0 && n2 != 0)
            cout<<total<<endl;
        
        total1 = total2 = 0;
    }   
    while (n1 != 0 && n2 != 0);
    
    return 0;
}
