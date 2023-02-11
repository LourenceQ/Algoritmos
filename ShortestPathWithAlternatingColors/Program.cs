/*
1129. Shortest Path with Alternating Colors
Medium

You are given an integer n, the number of nodes in a directed graph where the nodes are labeled from 0 to n - 1. Each edge is red or blue in this graph, and there could be self-edges and parallel edges.

You are given two arrays redEdges and blueEdges where:

redEdges[i] = [ai, bi] indicates that there is a directed red edge from node ai to node bi in the graph, and
blueEdges[j] = [uj, vj] indicates that there is a directed blue edge from node uj to node vj in the graph.
Return an array answer of length n, where each answer[x] is the length of the shortest path from node 0 to node x such that the edge colors alternate along the path, or -1 if such a path does not exist.
 

Example 1:
Input: n = 3, redEdges = [[0,1],[1,2]], blueEdges = []
Output: [0,1,-1]

Example 2:
Input: n = 3, redEdges = [[0,1]], blueEdges = [[2,1]]
Output: [0,1,-1]
 

Constraints:

1 <= n <= 100
0 <= redEdges.length, blueEdges.length <= 400
redEdges[i].length == blueEdges[j].length == 2
0 <= ai, bi, uj, vj < n
*/

namespace PathWithAlternateColors;
using static System.Console;
public class Program
{
    public static void Main(string[] args)
    {
        int[][] redEdges = new int[1][]
        {
            new int[] {0,1}
        };
        int[][] blueEdges = new int[1][]
        {
            new int[] {2,1}
        };
        int n = 3;

        var res = ShortestAlternatingPaths(n, redEdges, blueEdges);
        for (int i = 0; i < res.Length; i++)
        {
            WriteLine($"Resposta do algoritmo: {res[i]}");    
        }
        
    }

    private enum Color
    {
        None, Red, Blue
    }

    private struct BfsNode : IEquatable<BfsNode>
    {
        public readonly int Node;
        public readonly Color Color;

        public BfsNode(int node, Color color)
        {
            Node = node;
            Color = color;
        }

        public bool Equals(object obj)
        {
            return Equals((BfsNode)obj);
        }

        public bool Equals(BfsNode other)
        {
            return Node == other.Node && Color == other.Color;
        }

        public override int GetHashCode()
        {
            return Node + 117 * (int)Color;
        }
    }

    private static int Bfs(int from
        , int to
        , Dictionary<int, List<int>> red
        , Dictionary<int, List<int>> blue)
    {

        HashSet<BfsNode> visited = new();
        Queue<BfsNode> bfs = new();

        bfs.Enqueue(new BfsNode(from, Color.None));
        int length = 0;

        while (bfs.Count != 0)
        {
            int count = bfs.Count;

            while (count > 0)
            {
                var cur = bfs.Dequeue();
                count--;
                var node = cur.Node;
                var color = cur.Color;
                visited.Add(cur);

                if (node == to) return length;

                if (color == Color.None)
                {
                    AddEdges(node, Color.Blue, blue, bfs, visited);
                    AddEdges(node, Color.Red, red, bfs, visited);
                }
                else
                {
                    if (color == Color.Blue)
                        AddEdges(node, Color.Red, red, bfs, visited);
                    else
                        AddEdges(node, Color.Blue, blue, bfs, visited);
                }
            }
            length++;
        }

        return -1;
    }

    private static void AddEdges(int from
        , Color color
        , Dictionary<int, List<int>> edges
        , Queue<BfsNode> bfs
        , HashSet<BfsNode> visited)
    {
        if (!edges.ContainsKey(from)) return;

        foreach (var edge in edges[from])
        {
            var nextNode = new BfsNode(edge, color);
            if (!visited.Contains(nextNode))
                bfs.Enqueue(nextNode);
        }
    }

    public static int[] ShortestAlternatingPaths(int n, int[][] redEdges, int[][] blueEdges)
    {
        int[] res = new int[n];

        Dictionary<int, List<int>> red = new();
        Dictionary<int, List<int>> blue = new();

        ConvertEdges(redEdges, red);
        ConvertEdges(blueEdges, blue);

        for (int i = 0; i < n; i++)
        {
            res[i] = Bfs(0, i, red, blue);
        }

        return res;
    }

    private static void ConvertEdges(int[][] edges, Dictionary<int, List<int>> dict)
    {
        foreach (var edge in edges)
        {
            if (dict.ContainsKey(edge[0]))
            {
                dict[edge[0]].Add(edge[1]);
            }

            else
            {
                dict[edge[0]] = new List<int>() { edge[1] };
            }
        }
    }
}