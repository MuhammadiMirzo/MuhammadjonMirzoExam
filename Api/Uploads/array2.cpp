#include <iostream>
#include <cmath>
#include <algorithm>
using namespace std;
int main()
{
    int num,cnt=0;
    cin>>num;

    int array[num];
    for(int i=0; i<num; i++)
    {
        cin>>array[i];
    }
    for(int i=0;i<num;i++){

        if(array[i+1] == array[i])
        {
            cout<<"YES";
            return 0;
        }

    }

    cout<<"NO";
    return 0;
}

