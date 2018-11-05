namespace altarixtest
{
    using Models;
    using System;
    using System.Collections.Generic;

    public static class Dijkstra
    {
        public static void GetPathWeights(Tree tree)
        {
            // установка веса начального узла (корня)
            tree.PathWeight = tree.Weight;
            GetMinPathWeight(tree);
        }

        private static void GetMinPathWeight(Tree tree)
        {
            if (tree.leftNode != null)
            {
                tree.leftNode.PathWeight = Math.Min(tree.leftNode.PathWeight, tree.PathWeight + tree.leftNode.Weight);
                GetMinPathWeight(tree.leftNode);
            }

            if (tree.rightNode != null)
            {
                tree.rightNode.PathWeight = Math.Min(tree.rightNode.PathWeight, tree.PathWeight + tree.rightNode.Weight);
                GetMinPathWeight(tree.rightNode);
            }
        }

        public static List<Point> GetMinPathToEnd(Tree tree)
        {
            throw new NotImplementedException();
        }
    }
}