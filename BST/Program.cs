using System;
using System.ComponentModel;
using System.Diagnostics;

namespace BST
{
    class Program
    {
        static void Main(string[] args)
        {
            const int numberOfTestNodes = 10000;

            Console.WriteLine("=======================================================");
            Console.WriteLine("Test started with {0} nodes", numberOfTestNodes);
            Console.WriteLine("=======================================================");
            Tree_Test.Test(numberOfTestNodes, TestData.TestDataOrder.Ascending);
            Tree_Test.Test(numberOfTestNodes, TestData.TestDataOrder.Descending);
            Tree_Test.Test(numberOfTestNodes, TestData.TestDataOrder.Random);
            Console.WriteLine("=======================================================");
            Console.WriteLine("Test ended with {0} nodes", numberOfTestNodes);
            Console.WriteLine("=======================================================");
            /*
                        Console.WriteLine(bstRising.Count);
                        Console.WriteLine(bstFalling.Count);
                        Console.WriteLine(bstRandom.Count);
            */
        }
    }
}