using System;
using System.Collections.Generic;
using System.Text;

namespace BST
{
    class Node
    {
        public int Key { get; set; }
        public object Data { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public Node(int value)
        {
            Key = value;
            Data = null;
            Left = null;
            Right = null;
        }
    }
}
