using System;

namespace BinarySearchTrees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BST ICE ONE");
            Console.WriteLine("Pre-Order:");
            BinaryTree.GetAllInTree().PreOrder(BinaryTree.GetAllInTree().Root);
            Console.WriteLine();

            Console.WriteLine("In Order:");
            BinaryTree.GetAllInTree().InOrder(BinaryTree.GetAllInTree().Root);
            Console.WriteLine();

            Console.WriteLine("Post-Order:");
            BinaryTree.GetAllInTree().PostOrder(BinaryTree.GetAllInTree().Root);
            Console.WriteLine("\n");

            Console.WriteLine("BST ICE TWO");
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Enter an option: D for Delete , DS for Depth First Search, BS for Breadth-First Search");
                Console.WriteLine("Full list will be re-added after a different option is selected");
                string answer = Console.ReadLine();

                if (answer is "D" or "d")
                {
                    Console.WriteLine("Enter the number of the node youd like to delete");
                    BinaryTree.GetAllInTree().InOrder(BinaryTree.GetAllInTree().Root);
                    Console.WriteLine();
                    string numberToDelete = Console.ReadLine();
                    BinaryTree.binaryTree.Remove(Convert.ToInt32(numberToDelete));
                    Console.WriteLine($"{numberToDelete} deleted\nThe remaining numbers: ");
                    BinaryTree.binaryTree.InOrder(BinaryTree.binaryTree.Root);
                    Console.WriteLine();
                }
                else if (answer is "DS" or "ds" or "Ds" or "dS")
                {
                    Console.WriteLine("Enter a number you want to depth search");
                    string numberToDepthSearch = Console.ReadLine();
                    Console.Write("Pre-Order\t"); 
                    BinaryTree.GetAllInTree().PreOrder(BinaryTree.GetAllInTree().Search(Convert.ToInt32(numberToDepthSearch)));
                    Console.WriteLine();
                    Console.Write("In Order \t"); 
                    BinaryTree.GetAllInTree().InOrder(BinaryTree.GetAllInTree().Search(Convert.ToInt32(numberToDepthSearch)));
                    Console.WriteLine();
                    Console.Write("Post-Order \t");
                    BinaryTree.GetAllInTree().PostOrder(BinaryTree.GetAllInTree().Search(Convert.ToInt32(numberToDepthSearch)));
                    Console.WriteLine();

                }
                else if (answer is "BS" or "bs" or "Bs" or "bS")
                {
                    int numberToBreadthSearch = BinaryTree.GetAllInTree().GetTreeDepth();
                 
                    Console.WriteLine(numberToBreadthSearch);
                }
                else
                {
                    Console.WriteLine("Incorrect Input");
                }
            }

            Console.ReadLine();
        }
    }
}
