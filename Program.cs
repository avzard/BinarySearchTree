using System;

namespace BinarySearchTree_BST_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Binary_Search_Tree***");
            MyBinaryNode<int> binarySearchTree = new MyBinaryNode<int>(56);
            binarySearchTree.Insert(30);
            binarySearchTree.Insert(70);
            binarySearchTree.Display();
            Console.ReadKey();
        }
    }
}