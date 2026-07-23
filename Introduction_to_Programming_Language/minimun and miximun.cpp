#include <iostream>
#include <conio.h>

using namespace std;
int main ()
{
   int n,sum=0;
   cout<<"enter the number of students"<<endl;
   cin>>n;
   int arr[n];
   for(int i=0;i<n;i++)
   {
       cout<<"number for student "<<i+1<<"  = ";
       cin>>arr [i];
       sum=sum+arr[i];

   }
   cout<<"the total mark is = "<<sum<<endl;
   float avg = (float) sum/n;

   cout<<"the average number is = "<<avg<<endl;

   int max =arr[0];
   for (int i=1;i<n;i++)
   {
       if (max<arr[i])
       {
            max =arr[i];
       }
   }
   cout<<"the maximum number is = "<<max<<endl;
   int min =arr[0];
   for (int i=1;i<n;i++)
   {
       if (min>arr[i])
       {
            min =arr[i];
       }
   }
   cout<<"the minimum number is = "<<min;
getch();
}
