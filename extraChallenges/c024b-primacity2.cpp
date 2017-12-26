//Primacity
//Victor Tebar
//Es bastante lento

/*
The primacity of an integer is the number of distinct primes which divide it.

Given 3 integers A, B, and K, how many integers in the inclusive range [A, B] 
have a primacity of exactly K?

Example input

5
5 15 2
2 10 1
24 42 3
1000000 1000000 1
1000000 1000000 2

Example output

Case #1: 5
Case #2: 7
Case #3: 2
Case #4: 0
Case #5: 1

(Facebook Hackercup 2015, problem 1)
*/

#include <iostream>

using namespace std;

bool IsPrime(int num){
    int count = 2;
    while(count <= num/count){
        if(num%count == 0)
            return false;
        count++;
    }
    return true;
}

int GetNextPrime(int actual){
    bool newPrime = false;
    actual++;
    
    while(!newPrime){
        if(IsPrime(actual))
            newPrime = true;
        else
            actual++;
    }
    
    return actual;
}


bool HasPrimacity(int num,int primacity){
    int divs = 0;
    int actualPrime = 2;
    
    if(IsPrime(num)){
        if(primacity == 1)
            return true;
        else
            return false;
    }
    
    while(actualPrime <= num){
        if(num%actualPrime == 0)
            divs++; 
            
        actualPrime = GetNextPrime(actualPrime);
        
        if(divs > primacity){
            return false;
        }
    }
    
    if(divs < primacity)
        return false;
    
    return true;
}

int main(){
    int numTimes,primacity,total;
    int from,to;
    cin >> numTimes;
    
    for(int i=0; i < numTimes; i++){
        total = 0;
        cin >> from >> to >> primacity;
        
        for(int j=from; j <= to;j++){
            if(HasPrimacity(j,primacity))
                total++;
        }
        
        cout << "Case #" << i+1 << ": " << total << endl;
    }   
}
