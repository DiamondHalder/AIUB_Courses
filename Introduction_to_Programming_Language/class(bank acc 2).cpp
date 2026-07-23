#include <iostream>
using namespace std;
class A
{
    public:
    void hjk()
    {
        cout<<"function of class A"<<endl;
    }
};
class B:public A
{
    public:
    void hjk()
    {
        cout<<"function of class B"<<endl;
    }
};


int main()
{

B obj;
obj.A::hjk();
obj.hjk();



}
