#include <bits/stdc++.h>

using namespace std;

class Graph {
private:
    int vertices;
    vector<vector<int>> adjacencyList;

public:
    Graph(int V) : vertices(V), adjacencyList(V) {}

    void addEdge(int u, int v) {
        adjacencyList[u].push_back(v);
    }

    void dfs(int startVertex) {
        vector<bool> visited(vertices, false);
        stack<int> dfsStack;

        dfsStack.push(startVertex);

        while (!dfsStack.empty()) {
            int currentVertex = dfsStack.top();
            dfsStack.pop();

            if (!visited[currentVertex]) {
                cout << currentVertex << " ";
                visited[currentVertex] = true;


                for (auto it = adjacencyList[currentVertex].rbegin(); it != adjacencyList[currentVertex].rend(); ++it) {
                    if (!visited[*it]) {
                        dfsStack.push(*it);
                    }
                }
            }
        }
    }
};

int main() {
    int vertices, edges;

    // Input number of vertices and edges
    cout << "Enter the number of vertices: ";
    cin >> vertices;
    cout << "Enter the number of edges: ";
    cin >> edges;

    Graph graph(vertices);


    cout << "Enter the edges (format: source destination):" << endl;
    for (int i = 0; i < edges; ++i) {
        int u, v;
        cin >> u >> v;
        graph.addEdge(u, v);
    }


    int startVertex;
    cout << "Enter the starting vertex for DFS: ";
    cin >> startVertex;


    cout << "DFS Order starting from vertex " << startVertex << ": ";
    graph.dfs(startVertex);

    return 0;
}

