using System;

namespace BinarySearchTrees
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Pre-Order:");
            BinaryTree.GetTrees().PreOrder(BinaryTree.GetTrees().Root);
            Console.WriteLine();

            Console.WriteLine("In Order:");
            BinaryTree.GetTrees().InOrder(BinaryTree.GetTrees().Root);
            Console.WriteLine();

            Console.WriteLine("Post-Order:");
            BinaryTree.GetTrees().PostOrder(BinaryTree.GetTrees().Root);
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
