#include<iostream>
using namespace std;
int multiplication(int n, int i)
{
    return n*i;
}


main(void)
{
    int n;
    cin>>n;

    for(int i=1; i<=10  ; i++)
    {
    cout<<n<<"*"<<i <<"= "<<multiplication(n,i)<<endl;
    }


}
