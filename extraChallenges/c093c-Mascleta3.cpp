// Challenge 093: Mascleta
// Max and min in a series 

// Input sample
// 3
// 5 10 1 22 33 4
// 1 10
// 3 1 1 2
// 
// Output sample
// 33 1
// 10 10
// 2 1

// Luis Selles

#include <iostream>

using namespace std;

int main()
{
    int min,max,n,numbers,n2;
    
    cin >> cases;
    
    for(int i = 0; i < cases; i++)
    {
        cin >> data;
        
        for(int j =0; j < data; j++)
        {
            cin >> numbers;
            if(j == 0)
            {
                min = numbers;
                max = numbers;
            }
            
            if(min > numbers)
                min = numbers;
                
            if(max < numbers)
                max = numbers;
        }
        
        cout << max << " " << min << endl;
    }
    
    return 0;
}
