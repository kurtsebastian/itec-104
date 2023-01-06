namespace GraphFinals
{
    class graph
    {
        private int vertices;
        private List<Int32>[] adj;

        public graph(int v)
        {
            vertices = v;
            adj = new List<Int32>[v];
            for (int i = 0; i < v; i++)
            {
                adj[i] = new List<Int32>();
            }
        }
        public void addedge(int c, int v)
        {
            adj[c].Add(v);
        }
        public void DFS(int v)
        {
            bool[] visited = new bool[vertices];
            Stack<int> stack = new Stack<int>();
            visited[v] = true;
            stack.Push(v);

            while (stack.Count != 0)
            {
                v = stack.Pop();
                Console.WriteLine("next >" + v);
                foreach (int i in adj[v])
                {
                    if (!visited[i])
                    {
                        visited[i] = true;
                        stack.Push(i);
                    }
                }
            }


        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            graph g = new graph(4);
            g. addedge(1, 2);
            g.addedge(1, 3);    
            g.DFS(1);
        }
    }
}
