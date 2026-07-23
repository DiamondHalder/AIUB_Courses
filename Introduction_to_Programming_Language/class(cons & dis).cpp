#include<iostream>
using namespace std;
class A
{
public:
    A( )
    {
        cout<<"Constructor of class A"<<endl;

    }
    ~A( )
    {
        cout<<"Distructor of class A"<<endl;

    }
    void showdata( )
    {

        cout<<"Some data of class A"<<endl;
        A obj1;
    }

};
class B:public A
{
public:
    B( )
    {
        cout<<"Constructor of class B" <<endl;

    }
    ~B( )
    {

        cout<<"Distructor of class B"<<endl;

    }
    void showdata ( )
    {

        cout<<"some data of class B" <<endl;
        A obj;
        obj.showdata ( );
    }
};
int main ( )
{
    B obj;
    A obj1;
    obj.showdata ( ) ;
    obj1.showdata( ) ;

}
