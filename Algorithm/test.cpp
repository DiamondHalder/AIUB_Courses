#include <bits/stdc++.h>
using namespace std;


// Selection Sort
void selectionSort(int arr[], int n) {
    for (int i = 0; i < n - 1; i++) {
        int min_idx = i;
        for (int j = i + 1; j < n; j++) {
            if (arr[j] < arr[min_idx])
                min_idx = j;
        }
        if (min_idx != i)
            swap(arr[min_idx], arr[i]);
    }
}

// Insertion Sort
void insertionSort(int arr[], int n) {
    for (int i = 1; i < n; i++) {
        int key = arr[i];
        int j = i - 1;
        while (j >= 0 && arr[j] > key) {
            arr[j + 1] = arr[j];
            j = j - 1;
        }
        arr[j + 1] = key;
    }
}

// Bubble Sort
void bubbleSort(int arr[], int n) {
    for (int i = 0; i < n - 1; i++) {
        for (int j = 0; j < n - i - 1; j++) {
            if (arr[j] > arr[j + 1]) {
                swap(arr[j], arr[j + 1]);
            }
        }
    }
}

// Quick Sort
int partition(int arr[], int start, int end) {
    int pivot = arr[end];
    int i = start - 1;

    for (int j = start; j < end; j++) {
        if (arr[j] < pivot) {
            i++;
            swap(arr[i], arr[j]);
        }
    }
    swap(arr[i + 1], arr[end]);
    return i + 1;
}


void quickSort(int arr[], int start, int end) {
    if (start < end) {
        int pivot = partition(arr, start, end);
        quickSort(arr, start, pivot - 1);
        quickSort(arr, pivot + 1, end);
    }
}


// Merge Sort
void merge(int arr[], int l, int m, int r) {
    int n1 = m - l + 1;
    int n2 = r - m;

    vector<int> L(n1), R(n2);

    for (int i = 0; i < n1; i++)
        L[i] = arr[l + i];
    for (int j = 0; j < n2; j++)
        R[j] = arr[m + 1 + j];

    int i = 0, j = 0, k = l;

    while (i < n1 && j < n2) {
        if (L[i] <= R[j]) {
            arr[k] = L[i];
            i++;
        } else {
            arr[k] = R[j];
            j++;
        }
        k++;
    }

    while (i < n1) {
        arr[k] = L[i];
        i++;
        k++;
    }

    while (j < n2) {
        arr[k] = R[j];
        j++;
        k++;
    }
}

void mergeSort(int arr[], int l, int r) {
    if (l < r) {
        int m = l + (r - l) / 2;
        mergeSort(arr, l, m);
        mergeSort(arr, m + 1, r);
        merge(arr, l, m, r);
    }
}



// Counting Sort
void countingSort(vector<int>& arr) {

    int maxVal = *max_element(arr.begin(), arr.end());
    int minVal = *min_element(arr.begin(), arr.end());

    vector<int> count(maxVal - minVal + 1, 0);
    vector<int> output(arr.size());

    for (int i = 0; i < arr.size(); i++)
        count[arr[i] - minVal]++;

    for (int i = 1; i < count.size(); i++)
        count[i] += count[i - 1];

    for (int i = arr.size() - 1; i >= 0; i--) {
        output[count[arr[i] - minVal] - 1] = arr[i];
        count[arr[i] - minVal]--;
    }

    for (int i = 0; i < arr.size(); i++)
        arr[i] = output[i];
}


    int main() {
    int originalArr[] = {66, 33, 11, 22, 44};
    int n = sizeof(originalArr) / sizeof(originalArr[0]);
    int arr1[n], arr2[n], arr3[n], arr4[n], arr5[n];  // Create separate arrays for each sorting operation

    // Copy the original array into these arrays
    copy(begin(originalArr), end(originalArr), arr1);
    copy(begin(originalArr), end(originalArr), arr2);
    copy(begin(originalArr), end(originalArr), arr3);
    copy(begin(originalArr), end(originalArr), arr4);
    copy(begin(originalArr), end(originalArr), arr5);

    // Perform sorting for each array
    selectionSort(arr1, n);
    insertionSort(arr2, n);
    bubbleSort(arr3, n);
    quickSort(arr4, 0, n - 1);
    mergeSort(arr5, 0, n - 1);

    // Print the sorted arrays
    cout << "Selection Sort: ";
    for (int i = 0; i < n; ++i) {
        cout << arr1[i] << " ";
    }
    cout << endl;

    cout << "Insertion Sort: ";
    for (int i = 0; i < n; ++i) {
        cout << arr2[i] << " ";
    }
    cout << endl;

    cout << "Bubble Sort: ";
    for (int i = 0; i < n; ++i) {
        cout << arr3[i] << " ";
    }
    cout << endl;

    cout << "Quick Sort: ";
    for (int i = 0; i < n; ++i) {
        cout << arr4[i] << " ";
    }
    cout << endl;

    cout << "Merge Sort: ";
    for (int i = 0; i < n; ++i) {
        cout << arr5[i] << " ";
    }
    cout << endl;

    // Rest of your code for counting sort...

    return 0;
}

