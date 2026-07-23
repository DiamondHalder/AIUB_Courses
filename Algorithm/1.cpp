#include <iostream>
#include <vector>
#include <algorithm>

using namespace std;

// ... (sorting algorithms implementation)

int main() {
    // Example usage of sorting algorithms
    vector<int> arr = {66, 33, 11, 22, 44};
    vector<int> arrVec = {7, 3, 2, 8, 2, 3, 1};

    cout << "Original Array: ";
    for (int num : arr) {
        cout << num << " ";
    }
    cout << endl;

    // Calling each sorting algorithm
    vector<int> selectionSortArr = arr;
    selectionSort(selectionSortArr);
    cout << "Selection Sort: ";
    for (int num : selectionSortArr) {
        cout << num << " ";
    }
    cout << endl;

    vector<int> insertionSortArr = arr;
    insertionSort(insertionSortArr);
    cout << "Insertion Sort: ";
    for (int num : insertionSortArr) {
        cout << num << " ";
    }
    cout << endl;

    vector<int> bubbleSortArr = arr;
    bubbleSort(bubbleSortArr);
    cout << "Bubble Sort: ";
    for (int num : bubbleSortArr) {
        cout << num << " ";
    }
    cout << endl;

    vector<int> quickSortArr = arr;
    quickSort(quickSortArr, 0, quickSortArr.size() - 1);
    cout << "Quick Sort: ";
    for (int num : quickSortArr) {
        cout << num << " ";
    }
    cout << endl;

    vector<int> mergeSortArr = arr;
    mergeSort(mergeSortArr, 0, mergeSortArr.size() - 1);
    cout << "Merge Sort: ";
    for (int num : mergeSortArr) {
        cout << num << " ";
    }
    cout << endl;

    cout << "Original Array for Counting Sort: ";
    for (int num : arrVec) {
        cout << num << " ";
    }
    cout << endl;

    countingSort(arrVec);
    cout << "Counting Sort: ";
    for (int num : arrVec) {
        cout << num << " ";
    }
    cout << endl;

    return 0;
}
