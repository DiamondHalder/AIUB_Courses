#include <iostream>
using namespace std;

void Search(int a[],int n,int iteam)
{
    int B=0;
    for(int i=0;i<n;i++)
    {
        if(a[i]==iteam)
        {
            cout<<"Found! And the position is - "<<i+1;
            B++;
            break;
        }
    }
    if(B==0)
    {
        cout<<"NOT FOUND!!!!!";
    }


}




int main()
{
    int n ;
    cout<<"ENTER THE NUMBER OF ELEMENTS - ";
    cin>>n;
     int iteam;
     cout<<"ENTER THE NUMBER WHICH YOU WANT TO SEARCH - ";
     cin>>iteam;

    int a[n];
    cout<<"ENTER THE ELEMENTS - ";
    for(int i =0;i<n;i++)
    {
        cin>>a[i];
    }
    cout<<"the given array  - ";
     for(int i =0;i<n;i++)
    {
        cout<<a[i]<<" ";
    }
    cout<<endl;






  Search(a,n,iteam);
  main();

}
