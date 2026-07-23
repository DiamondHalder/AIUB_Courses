#include<iostream>
using namespace std;
class account
{
private:
    string accname,accnum;
    int bal;
public:
    void setvalue( string accname,string accnum ,int bal)
    {
        this->accname=accname;
         this->accnum=accnum;
          this->bal=bal;
    }
    account()
    {
        cout<<endl<<"constructor of account class"<<endl;
    }
    ~ account()
    {
        cout<<endl<<"distructor of account class"<<endl;
    }
    int deposite(int amount)
    {
        bal=bal+amount;
    }
    int withdraw(int amount)
    {
        bal=bal-amount;
    }
    void display()
    {
        cout<<"account name "<<accname<<endl<<"account number - "<<accnum<<endl<<"balance - "<<bal<<endl;
    }


};
class user :public account
{
private:
    string accown,phnnum;
public:
    void setvalue ( string accown,string phnnum)
    {
        this->accown=accown;
        this->phnnum=phnnum;
    }
    user()
    {
        cout<<endl<<"constructor of user class "<<endl;
    }
    ~ user()
    {
        cout<<endl<<"distructor of user class "<<endl;
    }
    void display()
    {
        cout<<"account owner name - "<<accown<<endl<<"phone number - "<<phnnum<<endl;

    }
};
int main ()
     {
        user obj;
         obj.setvalue("mou","01748015548");
          obj.account::setvalue("savings","32462374623746237",5000);
           obj.deposite(1000);
            obj.withdraw(3000);
             obj.display();
              obj.account::display();




     }

