#include<iostream>
using namespace std;
int maxn(int a,int b, int c) //problem 4
{
    if (a>b && a>c)
    {
        return a;
    }

    else if (b>a && b>c)
    {
        return b;
    }
    else
    {
     return c;

    }
}
    int minn(int a,int b, int c)
   {

    if (a<b && a<c)
    {
        return a;
    }

    else if (b<a && b<c)
    {
        return b;
    }
    else
    {
     return c;}
   }

     main ()
     {
         int a,b,c;
         cout<<"Please enter three number = ";
         cin>>a>>b>>c;
         cout<<"The maximum number is = "<<maxn(a,b,c)<<endl;
         cout<<"The minimum number is = "<<minn(a,b,c);

     }
