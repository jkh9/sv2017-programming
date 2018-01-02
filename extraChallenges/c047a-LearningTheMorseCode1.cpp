//Victor Tebar

/*
Aprendiendo el código Morse

Letra   Código      Letra   Código
A   .-          N   -.
B   -...        O   ---
C   -.-.        P   .--.
D   -..         Q   --.-
E   .           R   .-.
F   ..-.        S   ...
G   --.         T   -
H   ....        U   ..-
I   ..          V   ...-
J   .---        W   .--
K   -.-         X   -..-
L   .-..        Y   -.--
M   --          Z   --..


La palabra elegida para cada letra debe comenzar por esa letra y ser tal que si 
cada vocal 'o' se sustituye por una raya, y el resto de vocales por un punto, 
el resultado final sea la codificación de la letra en cuestión:

Letra   Palabra de referencia   Código
A   Arco    .-
B   Bogavante   -...
C   Corazones   -.-.

Entrada de ejemplo
Arco
Corazones
ARBOLES

Salida de ejemplo 
Arco OK
Corazones OK
ARBOLES X
*/

#include <iostream>
#include <cstring>

using namespace std;

string GetCode(char letter){
    string code = "";
    
    switch(letter){
        case 'a': code = ".-"; break;
        case 'b': code = "-..."; break;
        case 'c': code = "-.-."; break;
        case 'd': code = "-.."; break;
        case 'e': code = "."; break;
        case 'f': code = "..-."; break;
        case 'g': code = "--."; break;
        case 'h': code = "...."; break;
        case 'i': code = ".."; break;
        case 'j': code = ".---"; break;
        case 'k': code = "-.-"; break;
        case 'l': code = ".-.."; break;
        case 'm': code = "--"; break;
        case 'n': code = "-."; break;
        case 'o': code = "---"; break;
        case 'p': code = ".--."; break;
        case 'q': code = "--.-"; break;
        case 'r': code = ".-."; break;
        case 's': code = "..."; break;
        case 't': code = "-"; break;
        case 'u': code = "..-"; break;
        case 'v': code = "...-"; break;
        case 'w': code = ".--"; break;
        case 'x': code = "-..-"; break;
        case 'y': code = "-.--"; break;
        case 'z': code = "--.."; break;
    }
    
    return code;
}

int main(){
    string word,firstLetterCode,vocalsCode;
    
    do{
        getline(cin,word);
        
        if(word != ""){
            vocalsCode = "";
            firstLetterCode = GetCode(tolower(word[0]));
            
            for(int i=0;i < word.length();i++){
                switch(tolower(word[i])){
                    case 'o': vocalsCode += '-'; break;
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'u': vocalsCode += '.'; break;
                }
            }
            
            if(firstLetterCode == vocalsCode)
                cout << word << " OK" << endl;
            else
                cout << word << " X" << endl;
                
        }
        
    }while(word != "");
}
