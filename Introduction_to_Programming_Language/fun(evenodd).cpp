#include <iostream>
using namespace std;



void evenOdd(int a)    //problem 5
{
    if(a%2==0)
    {
        cout<<a <<"  is Even"<<endl;
    }
    else
    {
        cout<<a <<  "  is odd"<<endl;
    }
}



main(void )
{
    int a;
cout <<"Please enter a number = ";
cin>>a;



   evenOdd(a);
   main ( );







}
