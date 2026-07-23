#include <iostream>
#include <vector>
#include <queue>

using namespace std;

// Structure to represent an edge
struct Edge {
    int u, v, weight;
};

// Function to compare edges based on weight for priority queue
struct CompareEdge {
    bool operator()(const Edge& e1, const Edge& e2) {
        return e1.weight > e2.weight;
    }
};

// Function to implement Prim's Algorithm
int primMST(int n, const vector<Edge>& edges) {
    // Create a vector to store the adjacency list of the graph
    vector<vector<pair<int, int>>> adjList(n + 1);

    // Fill the adjacency list based on the given edges
    for (const Edge& edge : edges) {
        adjList[edge.u].emplace_back(edge.v, edge.weight);
        adjList[edge.v].emplace_back(edge.u, edge.weight);
    }

    // Initialize priority queue to store edges based on weight
    priority_queue<Edge, vector<Edge>, CompareEdge> pq;

    // Start with the first vertex (can be any vertex)
    int startVertex = 1;

    // Mark the start vertex as visited
    vector<bool> visited(n + 1, false);
    visited[startVertex] = true;

    // Enqueue all edges connected to the start vertex
    for (const auto& neighbor : adjList[startVertex]) {
        pq.push({startVertex, neighbor.first, neighbor.second});
    }

    // Initialize the total weight of the minimum spanning tree
    int totalWeight = 0;

    // Process vertices until the priority queue is empty
    while (!pq.empty()) {
        // Get the edge with the minimum weight
        Edge currentEdge = pq.top();
        pq.pop();

        int u = currentEdge.u;
        int v = currentEdge.v;
        int weight = currentEdge.weight;

        // If the other end of the edge is not visited, include it in the MST
        if (!visited[v]) {
            visited[v] = true;
            totalWeight += weight;

            // Enqueue all edges connected to the newly added vertex
            for (const auto& neighbor : adjList[v]) {
                pq.push({v, neighbor.first, neighbor.second});
            }
        }
    }

    return totalWeight;
}

int main() {
    int n, m;
    cout << "Enter the number of vertices and edges: ";
    cin >> n >> m;

    vector<Edge> edges;
    cout << "Enter the edges in the form (u, v, w) where u and v are endpoints and w is the weight:\n";
    for (int i = 0; i < m; ++i) {
        Edge edge;
        cin >> edge.u >> edge.v >> edge.weight;
        edges.push_back(edge);
    }

    int minSpanningTreeWeight = primMST(n, edges);

    cout << "Weight of the minimum spanning tree: " << minSpanningTreeWeight << endl;

    return 0;
}

