#include<iostream>
using namespace std;
class Account
{
private:
    string Account_name,Account_no,Account_type;
    int Balance;

public:
    Account (string Account_name,string Account_no,int  Balance ,string Account_type   )
    {

       this-> Account_name=Account_name;
       this->Account_no=Account_no;
        this-> Balance=Balance;
        this->Account_type=Account_type;
    }
    void get_values ( )
    {

     cout<<"Account name = "<<Account_name<<endl<<"Account no = " <<Account_no<<endl<<"Balance = "<< Balance<<endl<<"Account type = "<<Account_type<<endl;


    }




};
int main ( )
{

    Account obj1    ( "Badhon Kumar Biswas","7014123456415",1245,"Student"  );
    Account obj2    ( "Bony Dutta","7014565865",5000,"Savings"  )  ;
   obj1.get_values( ) ;
   obj2.get_values( ) ;

}
