namespace altarixtest
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int[,] array =  {
                { 1, 100, 3, 3 },
                { 0, 7, 7, 1 },
                { 7, 7, 7, 10 },
                { 0, 100, 0, 0 }
            };
            var root = TreeBuilder.BuildTree(array, 0, 0);
            Dijkstra.GetPathWeights(root);
            // Не реализовано - Dijkstra.GetMinPathToEnd(root);
            Console.WriteLine(TreeBuilder.GetEnd(root).PathWeight);
        }
    }
}