#include <iostream>
using namespace std;

void sum()
{
    int arr[5]={1,2,3,4,5};
    for(int i=0;i<5;i++)
    {
        int sum = arr[0]+arr[i];
    }
    cout<<sum;
}
int main()
{

    sum();

}
