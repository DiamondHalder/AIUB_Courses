#include<iostream>
using namespace std;

int factorial(int x)
{
    int fac = 1;
    if (x ==0 || x==1) //problem 9
        return fac;
    for(int i=1;i<=x;i++)
        fac = fac*i;
    return fac;
}

int main()
{
    int x;
    cout<<"Please enter a numbr= ";
    cin>>x;
    cout << factorial(x) <<endl;
}
