#include <iostream>
using namespace std;

int Search(int array[], int size, int curr) {

    for (int i = 0; i < size; i++) {
        if (array[i] == curr) {

            return true;
        }
    else{return false;}

}
}
void display()
{
    if (true)
        {
        cout << "Found" << endl;
        }
    else
        {
        cout << "Not found" << endl;
        }
}

int main() {
    int n;
    cout << "Enter the number of elements: ";
    cin >> n;

    int array[n];

    cout << "Enter the elements: ";
    for (int i = 0; i < n; i++) {
        cin >> array[i];
    }

    int curr;
    cout << "Enter the element to search for: ";
    cin >> curr;

    cout << "The given array: ";
    for (int i = 0; i < n; i++) {
        cout << array[i] << " ";
    }
    cout << endl;

    display();

    return 0;
}

