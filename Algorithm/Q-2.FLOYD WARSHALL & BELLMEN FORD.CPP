#include <iostream>
#include <vector>
#include <climits>
#include <cstdlib>
#include <ctime>
#include<chrono>

using namespace std;

const int V = 60;
const int E = 100;
const int INF = INT_MAX;

// Function to print the matrix
void printMatrix(vector<vector<int>>& dist) {
    for (int i = 0; i < V; i++) {
        for (int j = 0; j < V; j++) {
            if (dist[i][j] == INF)
                cout << "INF\t";
            else
                cout << dist[i][j] << "\t";
        }
        cout << endl;
    }
}

// Function to generate a random graph
void generateRandomGraph(vector<vector<int>>& graph) {
    srand(time(0));

    for (int i = 0; i < E; i++) {
        int src = rand() % V;
        int dest = rand() % V;
        int weight = rand() % 31 - 15; // Random weight in the range -15 to 15

        graph[src][dest] = weight;
    }
}

// Implementation of Floyd-Warshall algorithm
void floydWarshall(vector<vector<int>>& graph) {
    vector<vector<int>> dist(V, vector<int>(V, INF));

    // Copy graph to distance matrix
    for (int i = 0; i < V; i++)
        for (int j = 0; j < V; j++)
            if (graph[i][j] != 0)
                dist[i][j] = graph[i][j];

    // Floyd-Warshall algorithm
    for (int k = 0; k < V; k++)
        for (int i = 0; i < V; i++)
            for (int j = 0; j < V; j++)
                if (dist[i][k] != INF && dist[k][j] != INF && dist[i][k] + dist[k][j] < dist[i][j])
                    dist[i][j] = dist[i][k] + dist[k][j];

    // Print the result
    cout << "Floyd-Warshall Shortest Distances:\n";
    printMatrix(dist);
}

// Implementation of Bellman-Ford algorithm
void bellmanFord(vector<vector<int>>& graph) {
    vector<int> dist(V, INF);
    dist[0] = 0;

    // Relax all edges V-1 times
    for (int i = 0; i < V - 1; i++)
        for (int u = 0; u < V; u++)
            for (int v = 0; v < V; v++)
                if (graph[u][v] != INF && dist[u] != INF && dist[u] + graph[u][v] < dist[v])
                    dist[v] = dist[u] + graph[u][v];

    // Check for negative weight cycles
    for (int u = 0; u < V; u++)
        for (int v = 0; v < V; v++)
            if (graph[u][v] != INF && dist[u] != INF && dist[u] + graph[u][v] < dist[v])
                cout << "Graph contains negative weight cycle!\n";

    // Print the result
    cout << "\nBellman-Ford Shortest Distances:\n";
    for (int i = 0; i < V; i++)
        cout << "Vertex " << i << ": " << dist[i] << endl;
}

int main() {
    // Create and initialize the graph with INF weights
    vector<vector<int>> graph(V, vector<int>(V, INF));

    // Generate random graph with weights
    generateRandomGraph(graph);



    // Run Floyd-Warshall algorithm
    auto start_time_fw = chrono::high_resolution_clock::now();
    floydWarshall(graph);
    auto end_time_fw = chrono::high_resolution_clock::now();
    auto duration_fw = chrono::duration_cast<chrono::microseconds>(end_time_fw - start_time_fw);

    // Run Bellman-Ford algorithm
    auto start_time_bf = chrono::high_resolution_clock::now();
    bellmanFord(graph);
    auto end_time_bf = chrono::high_resolution_clock::now();
    auto duration_bf = chrono::duration_cast<chrono::microseconds>(end_time_bf - start_time_bf);

    // Compare time complexities
    cout << "\nTime Complexity Comparison:\n";
    cout << "Floyd-Warshall Time: " << duration_fw.count()/1e6 << " seconds\n";
    cout << "Bellman-Ford Time: " << duration_bf.count()/1e6 << " seconds\n";

/*
The analysis of time complexity for both method:

Floyd-Warshall Algorithm:
Time Complexity: O(V^3).

Bellman-Ford Algorithm:
Time Complexity: O(VE).


Now, In this program we have a directed graph of 60 vertices and 100 edges:

For Floyd-Warshall:

V = 60
Time Complexity = O(60^3) = O(216,000)
For Bellman-Ford:
V = 60, E = 100
Time Complexity = O(60 * 100) = O(6,000)
So,it can be said the Bellman-Ford algorithm is expected to be more efficient in terms of time complexity due to its O(VE) complexity
compared to the higher cubic complexity of Floyd-Warshall. However, it's important to note that the actual runtime can be influenced by
factors such as implementation details, hardware, and the specific characteristics of the graph.

*/


}
