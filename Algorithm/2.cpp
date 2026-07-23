#include <iostream>
#include <vector>
#include <algorithm>

using namespace std;

// Structure to represent an item
struct Item {
    int weight;
    int value;
    double valuePerWeight; // Value per unit weight
};

// Function to compare items based on value per weight
bool compareItems(const Item& item1, const Item& item2) {
    return item1.valuePerWeight > item2.valuePerWeight;
}

// Function to solve the fractional knapsack problem
double fractionalKnapsack(vector<Item>& items, int capacity) {
    // Calculate value per weight for each item
    for (Item& item : items) {
        item.valuePerWeight = static_cast<double>(item.value) / item.weight;
    }

    // Sort items in non-increasing order of value per weight
    sort(items.begin(), items.end(), compareItems);

    double totalValue = 0.0;
    int currentWeight = 0;

    // Iterate through sorted items and add to knapsack
    for (const Item& item : items) {
        if (currentWeight + item.weight <= capacity) {
            // Add the entire item to the knapsack
            totalValue += item.value;
            currentWeight += item.weight;
        } else {
            // Add a fraction of the item to fill the remaining capacity
            double remainingCapacity = capacity - currentWeight;
            totalValue += item.valuePerWeight * remainingCapacity;
            break; // Knapsack is full
        }
    }

    return totalValue;
}

int main() {
    int n; // Number of items
    cout << "Enter the number of items: ";
    cin >> n;

    vector<Item> items(n);

    cout << "Enter item weights and values:\n";
    for (int i = 0; i < n; i++) {
        cin >> items[i].weight >> items[i].value;
    }

    int capacity;
    cout << "Enter the knapsack capacity: ";
    cin >> capacity;

    double maxValue = fractionalKnapsack(items, capacity);

    cout << "The maximum value that can be obtained is: " << maxValue << endl;

    return 0;
}
