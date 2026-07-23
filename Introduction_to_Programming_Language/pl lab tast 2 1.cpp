#include <iostream>
using namespace std;
int main()
{
    int i,sum=0;
    cout<<"the natural numbers are:"<<endl;


    for(i = 1; i <= 10; i++)

    {
        cout<<i;
        sum = sum + i;

    }
    cout<<endl<<"the sum of the first 10 numbers are:"<<endl;



    cout<<sum;

}
