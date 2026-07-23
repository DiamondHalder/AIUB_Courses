#include <bits/stdc++.h>
using namespace std;

int main() {
    int i, n, a[10], l, r, mid, data, flag;

    cout << "Enter size of array: ";
    cin >> n;
    for (i = 0; i < n; i++) {
        cin >> a[i];
    }
    cout << "Enter the element you want to search: ";
    cin >> data;

    l = 0;
    r = n - 1;
    flag = 0;

    while (l <= r) {
        mid = l + (r - l) / 2;

        if (data == a[mid]) {
            cout << data << " present at " << mid << " index";
            flag = 1;
            break;
        } else if (data < a[mid])
            {
            r = mid - 1;
            }
        else {
                l = mid + 1;
             }
    }

    if (flag == 0) {
        cout << endl << data << " not present in array";
    }

    return -1;
}

