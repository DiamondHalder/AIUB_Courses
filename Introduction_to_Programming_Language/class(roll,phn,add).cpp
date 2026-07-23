#include<iostream>
using namespace std;
class student
{
private:
int roll_number;
string  phone_number;
string  address;
public:
 void set_valus(int roll_number,string phone_number,string  address   )
 {


  this->roll_number=roll_number;
this->phone_number=phone_number;
this ->address=address;


 }

void get_valus ( )
{
   cout<<"Roll Number = "<<roll_number<<endl<<"Phone Number = "<<phone_number<<endl<<"Address = "<<address<<endl;


}



};

int main (  )
{
  student obj1,obj2;
  obj1.set_valus (8,"017****","Dhaka"    );
  obj2.set_valus (7,"018***","Khulna"    );
  obj1.get_valus (   );
  obj2.get_valus (   );



}
