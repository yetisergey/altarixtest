using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Tree
    {
        private const int MAX_WEIGHT = 10000;
        public Point Point { get; set; }
        public int PathWeight { get; set; } = MAX_WEIGHT;
        public int Weight { get; set; }
        public Tree leftNode { get; set; }
        public Tree rightNode { get; set; }
        public override string ToString()
        {
            return $"{ Point.xPosition }-{ Point.yPosition }";
        }
    }
}
