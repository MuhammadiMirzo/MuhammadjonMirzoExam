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

        if(i%2==0)
        {
            cout<<array[i]<<" ";
        }



    }
    return 0;
}

