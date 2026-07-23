#include <iostream>
#include <string>
using namespace std;

class student {
public:
    string name;
    int roll_no;
};

int main() {
    student obj1;

    obj1.name = "john";
    obj1.roll_no = 2;

    cout << "Name: " << obj1.name << endl;
    cout << "roll: " << obj1.roll_no << endl;
}
