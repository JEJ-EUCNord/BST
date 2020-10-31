using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace BST
{
    class Tree_Test
    {
        public static void Test(int numberOfTestNodes, TestData.TestDataOrder testDataOrder)
        {
            Tree tree = new Tree();

            AddData(tree, numberOfTestNodes, testDataOrder);
            SearchData(tree, numberOfTestNodes, testDataOrder);
        }

        private static void AddData(Tree tree, int numberOfTestNodes, TestData.TestDataOrder testDataOrder)
        {
            TestData testData = new TestData(numberOfTestNodes, testDataOrder);

            Console.WriteLine("Order of test data is : {0}", testDataOrder.ToString());
            Console.Write("  Adding {0} nodes with values from 0 to {1}. ", testData.Keys.Length, testData.Keys.Length - 1);
            Stopwatch stopwatch = Stopwatch.StartNew();
            foreach (int key in testData.Keys)
            {
                tree.Insert(key);
            }
            stopwatch.Stop();
            Console.WriteLine("Time elapsed (ms) : {0}", stopwatch.ElapsedMilliseconds);
        }

        private static void SearchData(Tree tree, int numberOfTestNodes, TestData.TestDataOrder testDataOrder)
        {
            TestData testData = new TestData(numberOfTestNodes, testDataOrder);

            Console.Write("  Searching tree for values from 0 to {0}. ", tree.Count - 1);
            Stopwatch stopwatch = Stopwatch.StartNew();
            foreach (int key in testData.Keys)
            {
                tree.Search(key);
            }
            stopwatch.Stop();
            Console.WriteLine("Time elapsed (ms) : {0}", stopwatch.ElapsedMilliseconds);
        }
    }
}
