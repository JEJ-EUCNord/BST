using System;
using System.Collections.Generic;
using System.Text;

namespace BST
{
    class TestData
    {
        public enum TestDataOrder
        {
            Random,
            Ascending,
            Descending
        }

        public int[] Keys { get; set; }

        public TestData(int numberOfValues, TestDataOrder type)
        {
            Keys = new int[numberOfValues];
            switch (type)
            {
                case TestDataOrder.Random:
                    Random random = new Random();
                    List<int> values = new List<int>();
                    for (int value = 0; value < numberOfValues; value++)
                    {
                        values.Add(value);
                    }
                    for (int i = 0; i < numberOfValues; i++)
                    {
                        int randomNumber = random.Next(values.Count);
                        Keys[i] = values[randomNumber];
                        values.RemoveAt(randomNumber);
                    }
                    break;
                case TestDataOrder.Ascending:
                    for (int i = 0; i < numberOfValues; i++)
                    {
                        Keys[i] = i;
                    }
                    break;
                case TestDataOrder.Descending:
                    for (int i = 0; i < numberOfValues; i++)
                    {
                        Keys[i] = numberOfValues - 1 - i;
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
