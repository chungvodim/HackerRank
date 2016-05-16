using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class Graph
    {
        /*I used BFS to travel through the nodes. First, maintain an array separately to store the total number of child nodes + 1. So, 
         * you can initially assign all the leaf nodes with value 1 in this array. Now start from the last node and count the number of 
         * children for each node. This will work in bottom to top manner and the array that stores the number of child nodes will help 
         * in runtime to optimize the code. Once you get the array after getting the number of children nodes for all the nodes, 
         * just counting the nodes with even number of nodes gives the answer. Note: I did not include root node in counting in final 
         * step*/
        private int noVertices;
        private List<Tuple<int, int>>[] edges;
        private Dictionary<int, List<int>> vertices;

        public Graph(int noVertices)
        {
            this.noVertices = noVertices;
            // index = ngọn(có giá trị nhỏ nhất là 2), nên bắt đầu từ phần tử thứ 2 của mảng
            edges = new List<Tuple<int, int>>[noVertices + 1];

            vertices = new Dictionary<int, List<int>>();
            // không lưu giá trị vào phần tử đầu của mảng vertices, nên phải lặp tới noVertices
            for (int i = 0; i <= noVertices; i++)
            {
                edges[i] = new List<Tuple<int, int>>();
                vertices[i] = new List<int>();
            }
        }

        public void AddEdgeAndVert(int s, int e)
        {
            // s nhỏ nhất là 2
            edges[s].Add(new Tuple<int, int>(s, e));
            vertices[s].Add(e);
            vertices[e].Add(s);
        }

        public int countNoRemovableEdges()
        {
            int count = 0;
            for (int i = 1; i <= noVertices; i++)  // include V, vertices are numbered from 1, 2, ..., V
            {
                List<Tuple<int, int>> list = edges[i];

                for (int j = 0; j < list.Count; j++)
                {
                    HashSet<int> touched = new HashSet<int>();
                    Queue<int> queue = new Queue<int>();

                    int cur = list[j].Item1;
                    int next = list[j].Item2;

                    touched.Add(i);
                    touched.Add(next);

                    queue.Enqueue(next);
                    while (queue.Count > 0)
                    {
                        int first = queue.Dequeue();

                        foreach (int connect in vertices[first])
                        {
                            if (!touched.Contains(connect))
                            {
                                touched.Add(connect);
                                queue.Enqueue(connect);
                            }
                        }
                    }

                    if ((touched.Count % 2) == 1)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
    public static class GraphTheory
    {
    }
}
