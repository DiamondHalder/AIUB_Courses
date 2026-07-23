 #include <iostream>
 using namespace std;
 int main ()
 {
     int n,i, arr[]={2,3,4,5,6,7,9,3,4};

     n=sizeof arr/sizeof arr[0];
     i=n/2;
     cout<<arr[i+1];

 }
