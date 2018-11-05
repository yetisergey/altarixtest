namespace altarixtest
{
    using Models;
    using System.Collections.Generic;
    using System.Linq;

    public static class TreeBuilder
    {
        static TreeBuilder()
        {
            visitedNodes = new List<Tree>();
        }

        private static List<Tree> visitedNodes;

        public static Tree BuildTree(int[,] array, int xPosition, int yPosition)
        {
            var node = new Tree()
            {
                Point = new Point()
                {
                    xPosition = xPosition,
                    yPosition = yPosition
                },
                Weight = array[xPosition, yPosition]
            };

            visitedNodes.Add(node);

            if (xPosition + 1 < array.GetLength(0))
            {
                var visitedNode = visitedNodes.FirstOrDefault(u => u.Point.xPosition == xPosition + 1 && u.Point.yPosition == yPosition);
                if (visitedNode != null)
                    node.leftNode = visitedNode;
                else
                    node.leftNode = BuildTree(array, xPosition + 1, yPosition);
            }

            if (yPosition + 1 < array.GetLength(1))
            {
                var visitedNode = visitedNodes.FirstOrDefault(u => u.Point.xPosition == xPosition && u.Point.yPosition == yPosition + 1);
                if (visitedNode != null)
                    node.rightNode = visitedNode;
                else
                    node.rightNode = BuildTree(array, xPosition, yPosition + 1);
            }

            return node;
        }

        public static Tree GetEnd(Tree node)
        {
            if (node.leftNode != null)
                return GetEnd(node.leftNode);
            else if (node.rightNode != null)
                return GetEnd(node.rightNode);
            else return node;
        }
    }
}