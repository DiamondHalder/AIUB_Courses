
#include <iostream>
#include <vector>

using namespace std;

// Structure to represent an item
struct Item
{
    int weight;
    int value;
};

// Function to solve the 0/1 Knapsack problem
int knapsack(int W, vector<Item> &items)
{
    int n = items.size();
    vector<vector<int>> dp(n + 1, vector<int>(W + 1, 0));

    for (int i = 1; i <= n; i++)
    {
        for (int w = 1; w <= W; w++)
        {
            if (items[i - 1].weight > w)
            {
                dp[i][w] = dp[i - 1][w];
            }
            else
            {
                dp[i][w] = max(dp[i - 1][w], items[i - 1].value + dp[i - 1][w - items[i - 1].weight]);
            }
        }
    }

    return dp[n][W];
}

int main()
{
    vector<Item> items = {
        {2, 10},
        {3, 5},
        {5, 15},
        {7, 7}};

    int W = 10; // Maximum weight capacity of the knapsack

    int maxValue = knapsack(W, items);

    cout << "The maximum total value of items in the knapsack is: $" << maxValue << endl;

    return 0;
}
