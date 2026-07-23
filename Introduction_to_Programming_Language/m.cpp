#include <iostream>
#include <conio.h>
using namespace std;
int main ()
{
    int n;
    cout<<"INPUT THE NUMBER OF WHICH YOU WANT MAKE A MULTIPILICATION TABLE"<<endl;
    cin>>n;
    for(int i=1;i<=10;i++)
    {
        cout<<n<<"X"<<i<<"="<<n*i<<endl;
    }
     getch();

}

