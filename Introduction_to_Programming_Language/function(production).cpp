#include<iostream>
using namespace std;
void product(int x, int y)
{
  cout<<"The product of " <<x <<" & " <<y<<" is = "<<x*y;
}


main (  void)
{
    int a,b;
    cout<<"Please enter the two intiger number= "<<endl;
    cin>>a>>b;
 product(a,b);
}
