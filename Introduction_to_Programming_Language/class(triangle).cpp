#include <iostream>
using namespace std;
// number 3
class Triangle{
private:
    double a,b,c;
    double area()
    {
        return 0.5*a*b;
    }
    double primiter( )
    {
      return a+b+c;
    }
public:
    void set_values(double a, double b,double c)
    {
        this->a=a;
        this->b=b;
        this ->c=c;
    }
    void get_values()
    {
        cout<<a<<endl<<b<<'\t'<<c<<endl;
    }
    void display()
    {
        cout<< "Triangle of area is = "<<area()<<endl;
        cout<<"Triangle of primiter is = " <<primiter()<<endl;
    }
};
int main()
{
    Triangle obj1;

    obj1.set_values(3,4,5);
    obj1.display();
}
