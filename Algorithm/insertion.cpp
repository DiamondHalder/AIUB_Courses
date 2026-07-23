#include <iostream>
using namespace std;

void display(int array[],int size)
{
    for(int i=0;i<size;i++)
    {
        cout<<array[i]<<" ";

    }
}
void insertion(int array[],int size)
{
    for(int i=1;i<size;i++)
    {
        int key = array[i];
        int j = i-1;

        while (key<array[j]&& j>=0)
        {
            array[j+1]=array[j];
            --j;

        }array[j+1]=key;
    }

}

int main()
{

   // int data[]={1,4,5,3,2};
    //int size = sizeof(data)/sizeof(data[0]);
    int n;
    cout<<"enter the number of elements - "<<endl;
    cin>>n;
    int array[n];
    cout<<"enter the elements - "<<endl;
    for(int i = 0;i<n;i++)
    {
        cin>>array[i];
    }
    cout<<"the given array - ";
    for(int i = 0;i<n;i++)
    {
        cout<<array[i]<<" ";
    }
    cout<<endl;



    insertion(array,n);
    cout<<"this s the sorted array - ";
    display(array,n);
}
