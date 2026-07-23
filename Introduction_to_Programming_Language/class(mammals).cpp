#include <iostream>



using namespace std;



class Mammals
{
public:
    void mammalsShow()
    {
        cout<<"Mammals"<<endl;
    }



} ;



class MarineAnimal
{
public:
    void MarineShow()
    {
        cout<<"Marine"<<endl;
    }



} ;



class BlueWhale : public Mammals, public MarineAnimal
{
public:
    void BlueShow()
    {
        cout<<"I am both"<<endl;
    }



} ;



int main()
{
    Mammals obj1;
    obj1.mammalsShow();



    MarineAnimal obj2;
    obj2.MarineShow();



    BlueWhale obj3;
    obj3.BlueShow();



    obj3.mammalsShow();
    obj3.MarineShow();
}
