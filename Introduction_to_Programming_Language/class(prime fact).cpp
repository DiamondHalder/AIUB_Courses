#include<iostream>
using namespace std;
int primefact( int n)
{
 int i;
 for( i=2; n>1; i++)
 {
     while( n%i==0)
     {
         cout<<i;
         n=n/i;
     }
 }
}



main ( void)
{
 int n;
 cin>>n;
 primefact(n);



}
