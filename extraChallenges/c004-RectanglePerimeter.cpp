// Perimeter of a Rectangle
// Miguel Pastor 

#include <iostream>
using namespace std;

int main ()
{
    int x = 0 , y = 0, result;
        
    while (x >= 0 && y >= 0)
    {
        cin >> x >> y;
        
        if(x < 0 || y < 0)
            return 0;

        result = 2* (x + y);           
        cout << result << endl;
    }
    return 0;
}



