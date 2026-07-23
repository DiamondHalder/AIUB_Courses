#include<iostream>
using namespace std;
int vote(int age)
{
    if (age>=18)
    {
      return age ;//cout<<"You are eligibale for vote";//problem 6
    }

   // else
    {
       // cout<<"You are not eligible for vote";
    }
}
main (void)
{
    int age;
    cout<<"Please enter your age= ";
    cin>>age;
    cout<< vote(age);



}
