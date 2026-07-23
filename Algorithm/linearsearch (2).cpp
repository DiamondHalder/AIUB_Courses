#include <iostream>
using namespace std;

class A {
    public:

        int Search(int array[], int size, int curr)
         {
    for (int i = 0; i < size; i++) {
        if (array[i] == curr) {
            return true;
        }
    else{return false;}

}
}
void display(int curr,bool found)
{
    if (true)
        {
        cout << "Found!!!! And the element is - " <<curr<< endl;
        }
    else
        {
        cout << "Not found" << endl;
        }
}

};



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

   A obj;
    bool found = obj.Search(array, n, curr);

    obj.display(curr, found);

    return 0;
}

