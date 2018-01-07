//Almudena Lopez Sanchez

/* Challenge 052: Next plate

Entrada de ejemplo
1234 BBB
9999 BBZ
9999 BBD
9999 ZZZ

Salida de ejemplo 
1235 BBB
0000 BCB
0000 BBF
*/

#include<iostream>
using namespace std;
int main()
{
    int nums;
    string letras;
    bool finish = false;
    do
    {
        finish = false;
        cin >> nums;
        cin >> letras;
        
        if(nums >= 9999 && letras == "ZZZ")
        {
            finish = true;
        }
        else
        {
            if(nums < 9999)
            {
                nums++;
                printf("%04d",nums);
                cout << " " << letras << endl;
            }   
            else
            {
                if(letras[1] == 'Z' && letras[2] == 'Z')
                {
                    char letra = letras[0];
                    letra++;
                    if (letra == 'A' || letra == 'E' || letra == 'I' || 
                        letra == 'O' || letra == 'U')
                        letra++;
                    letras = letra;
                    letras += "BB";
                }
                else if(letras[2] != 'Z')
                {
                    char letra = letras[2];
                    letra++;
                    if (letra == 'A' || letra == 'E' || letra == 'I' || 
                        letra == 'O' || letra == 'U')
                        letra++;
                    
                    letras = letras.replace(2, 1, "");
                    letras += letra;    
                }
                else
                {
                    char letra = letras[1];
                    letras = letras.replace(1, 2, "");
                    letra++;
                    if (letra == 'A' || letra == 'E' || letra == 'I' || 
                        letra == 'O' || letra == 'U')
                        letra++;
                    letras += letra;
                    letras += "B";
                }
                nums = 0;
                printf("%04d",nums);
                cout << " " << letras << endl;
            }   
        }   
    }
    while(!finish);
}
