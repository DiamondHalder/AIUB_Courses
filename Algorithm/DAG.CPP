#include <iostream>
#include <vector>
#include <stack>
#include <unordered_set>

using namespace std;

class Graph {
public:
    int vertices;
    vector<vector<int>> adjacencyList;

    Graph(int V) {
        vertices = V;
        adjacencyList.resize(vertices);
    }

    void addEdge(int from, int to) {
        adjacencyList[from].push_back(to);
    }

    void topologicalSortUtil(int v, vector<bool>& visited, stack<int>& order) {
        visited[v] = true;

        for (int neighbor : adjacencyList[v]) {
            if (!visited[neighbor]) {
                topologicalSortUtil(neighbor, visited, order);
            }
        }

        order.push(v);
    }

    void topologicalSort() {
        stack<int> order;
        vector<bool> visited(vertices, false);

        for (int i = 0; i < vertices; ++i) {
            if (!visited[i]) {
                topologicalSortUtil(i, visited, order);
            }
        }

        while (!order.empty()) {
            cout << order.top() << " ";
            order.pop();
        }
    }
};

int main() {
    // Example usage
    Graph graph(6);
    graph.addEdge(5, 2);
    graph.addEdge(5, 0);
    graph.addEdge(4, 0);
    graph.addEdge(4, 1);
    graph.addEdge(2, 3);
    graph.addEdge(3, 1);

    cout << "Topological Order: ";
    graph.topologicalSort();

    return 0;
}

