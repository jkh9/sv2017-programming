/*
Cálculo de la mediana (doble de la mediana de los datos de entrada)

Entrada de ejemplo
11
1 2 6 17 18 22 35 46 109 153 200
5
5 3 1 2 8
4
4 5 9 2
0

Salida de ejemplo
44
6
9
*/

// Victor Tebar, minor improvement by Nacho

#include <iostream>
#include <vector>
#include <algorithm>

using namespace std;

bool compare(float num1,float num2){
    return num1 < num2;
}

int main() {
    int quantity;
    vector<float> nums;
    
    do{
        cin >> quantity;
        
        if(quantity != 0){
            float num;
            
            for(int i=0; i < quantity;i++){
                cin >> num;
                nums.push_back(num);
            }
            sort(nums.begin(),nums.begin() + nums.size(),compare);  
            
            if(quantity%2 != 0){
                cout << nums[quantity/2] * 2 << endl;
            }
            else{ // Minor improvement by Nacho
                cout << nums[quantity/2 - 1] + nums[quantity/2]  << endl; 
            }
            
            nums.clear();
        }
    }while(quantity != 0);
}
