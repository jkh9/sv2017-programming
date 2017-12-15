#include <iostream>

using namespace std;

int main()
{
	string message;
	do{
		getline(cin, message);
		if(message != "FIN")
		{
			for(int i = 0; i < message.length(); i++)
			{
				if(message[i] != ' ')
				{
					if(message[i] == 'Z')
						message[i] = 'A';
					else
						message[i]++;
				}	
			}
			cout << message << endl;	
		}	
	}while(message != "FIN");
			
	return 0;
}
