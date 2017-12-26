/*

The buffer!
Input

The first line will contain the number of cases.
After that, each line will be the numbers of wall-mounted urinals in a bathroom.

Output

The number of men that can use the urinals simultaneously.

Sample Input

5
1
2
3
4
5

Sample Output

1
1
2
2
3
*/

// Almudena Lopez

#include<iostream>
using namespace std;
int main()
{
    int urinarios;
    int num;
    cin >> num;
    for(int i = 0; i < num; i++)
    {
        cin >> urinarios;
        if( urinarios % 2 == 0)
            cout << urinarios/2 << endl;
        else
            cout << (urinarios/2)+1 << endl;
    }
}
