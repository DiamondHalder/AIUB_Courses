

#include <iostream>
using namespace std;

void countSort(int a[], int size) {

  int Count[10];
  int count[10];
  int k = a[0];


  for (int i = 1; i < size; i++) {
    if (a[i] > k)
      k = a[i];
  }


  for (int i = 0; i <= k; ++i) {
    count[i] = 0;
  }


  for (int i = 0; i < size; i++) {
    count[a[i]]++;
  }


  for (int i = 1; i <= k; i++) {
    count[i] = count[i] + count[i - 1];
  }


  for (int i = size - 1; i >= 0; i--) {

    Count[--count[a[i]]] = a[i];

  }


  for (int i = 0; i < size; i++) {
    a[i] = Count[i];
  }
}


void printa(int a[], int size) {
  for (int i = 0; i < size; i++)
    cout << a[i] << " ";
  cout << endl;
}


int main() {

  int n;
    cout<<"enter the number of elements - "<<endl;
    cin>>n;
    int array[n];
    cout<<"enter the elements - "<<endl;
    for(int i = 0;i<n;i++)
    {
        cin>>array[i];
    }
  countSort(array, n);
  printa(array, n);
}
