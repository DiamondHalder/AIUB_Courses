#include<iostream>
using namespace std;
class Parking
{
 private:
     string car_model,car_number;
     int total_count;
 public:
    void Set_value(string car_model,string car_number,int total_count  )
    {

     this-> car_model=car_model;
     this-> car_number=car_number;
     this-> total_count=total_count;


    }
    Parking (string car_model,string car_number,int total_count  )
    {

     this-> car_model=car_model;
     this-> car_number=car_number;
     this-> total_count=total_count;


    }
    Parking ( )
    {
        cout<<"Empty";
    }

    void get_value( )
    {
        cout<<car_model<<endl<<car_number<<endl<<total_count<<endl;
    }
   void add( int car )
    {

     total_count=total_count+car;

    }
    void sub (int car )
    {
      total_count=total_count-car;
    }

    void display (  )
    {

cout<<car_model<<endl<<car_number<<endl<<total_count<<endl;

    }


};
int main ( )
{
 Parking obj1 ("BMW","DHAKA METRO 22",22  );
 obj1.add( 1);
 obj1.sub ( 1 ) ;
 obj1.display ( );


}
