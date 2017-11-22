//Victor Tebar
#include <iostream>
#include <cstring>
#include <vector>

using namespace std;

int main(){
    int count = 0;
    vector<string> allWords;
    string sentence,word = "";
    string firstWord,secondWord;
    bool chained = true;
    
    getline(cin,sentence);
    //Separate the words
    while(count < sentence.length())
    {
        if(sentence[count] != ' ')
            word += sentence[count];
        else
        {
            allWords.push_back(word);
            word = "";
        }
        count++;
    }
    if(word != "")
        allWords.push_back(word);
    count = 0;
    
    while(count < allWords.size() && chained)
    {
        firstWord = "";
        secondWord = "";
        if(count != allWords.size()-1)
        {
            firstWord += allWords[count][allWords[count].size()-2];
            firstWord += allWords[count][allWords[count].size()-1];
            secondWord += allWords[count+1][0];
            secondWord += allWords[count+1][1];
            if(firstWord != secondWord)
                chained = false;
        }
        count++;
    }
    
    if(chained)
        cout << "SI" << endl;
    else
        cout << "NO" << endl;
}
