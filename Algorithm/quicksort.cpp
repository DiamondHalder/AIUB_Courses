
#include <iostream>
using namespace std;


void swap(int& a, int& b) {
    int temp = a;
    a = b;
    b = temp;
}


int partition(int arr[], int low, int high) {
    int pivot = arr[low];
    int i = low + 1;
    int j = high;

    while (true) {

        while (i <= j && arr[i] <= pivot) {
            i++;
        }


        while (i <= j && arr[j] >= pivot) {
            j--;
        }

        if (i > j) {
            break;
        }

        swap(arr[i], arr[j]);
    }

    swap(arr[low], arr[j]);
    return j;
}


void quickSort(int arr[], int low, int high) {
    if (low < high) {
        int pivotIndex = partition(arr, low, high);


        quickSort(arr, low, pivotIndex - 1);
        quickSort(arr, pivotIndex + 1, high);
    }
}


void printArray(int arr[], int size) {
    for (int i = 0; i < size; i++) {
        cout << arr[i] << " ";
    }
    cout <<endl;
}

int main() {
    /*int arr[] = { 10, 7, 8, 9, 1, 5 };
    int size = sizeof(arr) / sizeof(arr[0]);*/

    int n;
    cout<<"enter the number of elements - "<<endl;
    cin>>n;
    int array[n];
    cout<<"enter the elements - "<<endl;
    for(int i = 0;i<n;i++)
    {
        cin>>array[i];
    }

    cout << "Original array: ";
    printArray(array, n);

    quickSort(array, 0, n - 1);

    cout << "Sorted array: ";
    printArray(array, n);

    return 0;
}
