using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree_BST_
{
    class MyBinaryNode<T> where T : IComparable<T>
    {
        T NodeData;
        public MyBinaryNode<T> leftTree { get; set; }
        public MyBinaryNode<T> rightTree { get; set; }

        int leftCount = 0;
        int rightCount = 0;

        public MyBinaryNode(T NodeData)
        {
            this.NodeData = NodeData;
            leftTree = null;
            rightTree = null;
        }
        public void Insert(T item)
        {
            T currentNodeValue = NodeData;
            if ((currentNodeValue.CompareTo(item)) > 0)
            {
                if (leftTree == null)
                    leftTree = new MyBinaryNode<T>(item);
                else
                    leftTree.Insert(item);
            }
            else
            {
                if (rightTree == null)
                    rightTree = new MyBinaryNode<T>(item);
                else
                    rightTree.Insert(item);
            }
        }
        public void Display()
        {
            if (leftTree != null)
            {
                leftTree.Display();
            }
            Console.WriteLine(NodeData.ToString());
            if (rightTree != null)
            {
                rightTree.Display();
            }
        }
        public void Size()
        {
            Console.WriteLine("Size of BST is " + (1 + leftCount + rightCount));
        }
    }
}