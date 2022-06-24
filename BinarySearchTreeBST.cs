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

        bool result = false;
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
        public bool ifExists(T element, MyBinaryNode<T> node)
        {
            if (node == null)
                return false;
            if (node.NodeData.Equals(element))
            {
                Console.WriteLine("Element Found In BST :" + node.NodeData);
                return true;
            }
            else
                Console.WriteLine("Current element is {0} in BST ", node.NodeData);
            if (element.CompareTo(node.NodeData) < 0)
                ifExists(element, node.leftTree);
            if (element.CompareTo(node.NodeData) > 0)
                ifExists(element, node.rightTree);
            return result;
        }
    }
}