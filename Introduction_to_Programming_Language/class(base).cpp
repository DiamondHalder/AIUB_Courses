#include<iostream>
using namespace std;
class base1 {
  public:
      void someFunction( )
       {cout<<"base 1";}
};
class base2 {
    void someFunction1( )
     {cout<<endl<<"base 2";}
};
class derived : public base1, public base2 {};

int main() {
    derived obj;
    obj.someFunction();
    obj.someFunction1();
}
