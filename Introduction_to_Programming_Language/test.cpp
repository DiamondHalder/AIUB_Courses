#include <iostream>

using namespace std;

int main()
{
int a = 45674;

int d1 = a/10000;
a = a%10000;

int d2 = a/1000;
a = a%1000;

int d3 = a/100;
a = a%100;

int d4 = a/10;
int d5 = a%10;

a = d5*10000+d4*1000+d3*100+d4*10+d5;

cout<<a;}

//cout<<d5<<endl<<d4<<endl<<d3<<endl<<d2<<endl<<d1;}

