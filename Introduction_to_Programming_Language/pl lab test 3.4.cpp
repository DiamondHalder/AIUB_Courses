#include <iostream>
using namespace std;
int main ()
{

    int arr [3]={3,4,5};
    int tem =arr[0];



    for (int i=0;i<3;i++){
    if (arr [i]>tem)
    {
        tem=arr [i];
    }}
    cout<<tem;
}
