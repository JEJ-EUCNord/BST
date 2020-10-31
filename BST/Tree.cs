using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace BST
{
    class Tree
    {
        private Node root;

        public int Count
        {
            get { return CountNodes(root); }
        }


        public Tree()
        {
            root = null;
        }

        public void Insert(int key)
        {
            Insert(ref root, key);
        }

        private void Insert(ref Node node, int key)
        {
            if (node == null)
            {
                node = new Node(key);
            }
            else if (key < node.Key)
            {
                Node n = node.Left;   // ...ToDo...  Workaround as attributes cant be passed as 'ref' parameter
                Insert(ref n, key);
                node.Left = n;        // ...ToDo...  Workaround as attributes cant be passed as 'ref' parameter
            }
            else
            {
                Node n = node.Right;   // ...ToDo...  Workaround as attributes cant be passed as 'ref' parameter
                Insert(ref n, key);
                node.Right = n;        // ...ToDo...  Workaround as attributes cant be passed as 'ref' parameter
            }
            return;
        }

        public Node Search(int key)
        {
            return Search(root, key);
        }

        private Node Search(Node node, int key)
        {
            if (node == null || node.Key == key)
                return node;
            return key < node.Key ? Search(node.Left, key) : Search(node.Right, key);
        }

        private int CountNodes(Node node)
        {
            return node == null ? 0 : CountNodes(node.Left) + CountNodes(node.Right) + 1;
        }

        public void List()
        {
            List(root);
        }

        private void List(Node node)
        {
            if (node != null)
            {
                List(node.Left);
                Console.Write(node.Key + " ");
                List(node.Right);
            }
        }
    }
}
