#include<bits/stdc++.h>
using namespace std;
int main()
{
    int i,n,a[10],l,r,mid,data,flag;

    cout<<"enter size of array: ";
    cin>>n;
    for(i=0;i<n;i++)
    {
        cin>>a[i];
    }
    cout<<endl<<"enter the element you want to search: ";
    cin>>data;
    l=0;
    r=n-1;
    while(l<=r)
    {
        flag=0;
        mid=(l+r)/2;
        if(data==a[mid])
        {
            cout<<data<<" present at "<<mid<<" index";
            flag=1;
        }
        else if(data<a[mid])
        {
            r=mid-1;
        }
        else
        {
            l=mid+1;
        }
        if(flag==1)
        break;
    }
    if(l>r)
    {
        cout<<endl<<data<<" not present in array";
        //return -1;
    }

}

