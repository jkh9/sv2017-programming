// Minutes to midnight
// Victor Tebar

#include <iostream>
#include <cstring>
#include <cstdlib>

using namespace std;

int main()
{
    int hour,minute;
    string time,hourTime,minuteTime;
    
    do
    {
        hourTime = "";
        minuteTime = "";
        getline(cin,time);
        for(int i=0;i<2;i++)
            hourTime += time[i];
        for(int i=3;i<5;i++)
            minuteTime += time[i];
        hour = atoi(hourTime.c_str());
        minute = atoi(minuteTime.c_str()) + atoi(hourTime.c_str())*60;
        if(hour != 0 || minute != 0)
        {
            cout << 1440 - minute << endl;
        }
    }
    while(hour != 0 || minute != 0);
    return 0;
}
