#include <iostream>
using namespace std;

void Merge(int* A, int L, int Mid, int R) {
    int i = L;
    int j = Mid + 1;
    int k = L;
    int temp[R + 1];
    while (i <= Mid && j <= R) {
        if (A[i] <= A[j]) {
            temp[k] = A[i];
            i++;
        } else {
            temp[k] = A[j];
            j++;
        }
        k++;

        if (i > Mid) {
            while (j <= R) {
                temp[k] = A[j];
                j++;
                k++;
            }
        } else if (j > R) {
            while (i <= Mid) {
                temp[k] = A[i];
                i++;
                k++;
            }
        }
    }
    for (int i = L; i <= R; i++) {
        A[i] = temp[i];
    }
}

void MergeSort(int* A, int L, int R) {
    int Mid;
    if (L < R) {
        Mid = (L + R) / 2;
        MergeSort(A, L, Mid);
        MergeSort(A, Mid + 1, R);
        Merge(A, L, Mid, R);
    }
}

void Display(int A[], int size) {
    for (int i = 0; i < size; i++) {
        cout << " " << A[i];
    }
    cout << endl;
}

int main() {
    int size;
    cout << "Enter the size of the array: ";
    cin >> size;
    int arr[size];
    cout << "Enter " << size << " elements: ";
    for (int i = 0; i < size; i++) {
        cin >> arr[i];
    }

    int L = 0;
    int R = size - 1;
    cout << "Array before sorting" << endl;
    Display(arr, size);
    cout << "Array after sorting" << endl;
    MergeSort(&arr[0], L, R);
    Display(arr, size);

    return 0;
}

