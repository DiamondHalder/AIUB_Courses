#include <iostream>
#include <vector>
#include <climits>
#include <ctime>

using namespace std;

// Function to generate a random number in the range [-15, 15]
int getRandomWeight() {
    return rand() % 31 - 15;
}

// Class to represent the directed graph
class Graph {
public:
    int vertices;
    vector<vector<int>> edges;

    Graph(int v) : vertices(v), edges(v, vector<int>(v, INT_MAX)) {}

    // Function to add a directed edge with a random weight
    void addEdge(int from, int to) {
        edges[from][to] = getRandomWeight();
    }
};

// Implementation of the Floyd-Warshall algorithm
void floydWarshall(Graph& graph, vector<vector<int>>& dist) {
    int V = graph.vertices;

    // Copying the original edge weights to the 'dist' matrix
    dist = graph.edges;

    // Applying the Floyd-Warshall algorithm
    for (int k = 0; k < V; ++k)
        for (int i = 0; i < V; ++i)
            for (int j = 0; j < V; ++j)
                if (dist[i][k] != INT_MAX && dist[k][j] != INT_MAX && dist[i][k] + dist[k][j] < dist[i][j])
                    dist[i][j] = dist[i][k] + dist[k][j];
}

// Implementation of the Bellman-Ford algorithm
void bellmanFord(Graph& graph, int source, vector<int>& dist) {
    int V = graph.vertices;
    dist.resize(V, INT_MAX);
    dist[source] = 0;

    // Relaxing edges repeatedly
    for (int i = 1; i <= V - 1; ++i)
        for (int u = 0; u < V; ++u)
            for (int v = 0; v < V; ++v)
                if (graph.edges[u][v] != INT_MAX && dist[u] != INT_MAX && dist[u] + graph.edges[u][v] < dist[v])
                    dist[v] = dist[u] + graph.edges[u][v];
}

int main() {
    srand(time(0));


    Graph graph(60);


    for (int i = 0; i < 100; ++i) {
        int from = rand() % 60;
        int to = rand() % 60;
        graph.addEdge(from, to);
    }


    vector<vector<int>> floydDist;
    vector<int> bellmanDist;

    // Measure time taken by Floyd-Warshall
    clock_t start = clock();
    floydWarshall(graph, floydDist);
    clock_t end = clock();
    double floydTime = double(end - start) / CLOCKS_PER_SEC;

    // Measure time taken by Bellman-Ford
    start = clock();
    bellmanFord(graph, 0, bellmanDist); // Assuming 0 is the source vertex
    end = clock();
    double bellmanTime = double(end - start) / CLOCKS_PER_SEC;

    // Output the time taken by each algorithm
    cout << "Floyd-Warshall Time: " << floydTime << " seconds\n";
    cout << "Bellman-Ford Time: " << bellmanTime << " seconds\n";

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
