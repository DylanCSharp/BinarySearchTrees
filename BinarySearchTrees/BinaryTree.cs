using System;

namespace BinarySearchTrees
{
    public class BinaryTree
    {
        public Node Root { get; set; }

        public static BinaryTree binaryTree = new();

        public static BinaryTree GetTrees()
        {
            binaryTree.Add(50);
            binaryTree.Add(30);
            binaryTree.Add(25);
            binaryTree.Add(75);
            binaryTree.Add(82);
            binaryTree.Add(28);
            binaryTree.Add(63);
            binaryTree.Add(70);
            binaryTree.Add(4);
            binaryTree.Add(43);
            binaryTree.Add(74);
            binaryTree.Add(35);
            binaryTree.Add(23);
            binaryTree.Add(41);
            binaryTree.Add(22);

            return binaryTree;
        }

        public bool Add(int value)
        {
            Node before = null; 
            Node after = Root;
            while (after != null)
            {
                before = after;
                if (value < after.Data)
                {
                    after = after.LeftNode;
                }
                else if (value > after.Data)
                {
                    after = after.RightNode;
                }
                else
                {
                    return false;
                }
            }

            Node newNode = new() 
            { 
                Data = value 
            };

            if (Root == null)
            {
                Root = newNode;
            }
            else
            {
                if (value < before.Data)
                {
                    before.LeftNode = newNode;
                }
                else
                {
                    before.RightNode = newNode;
                }
            }
            return true;
        }

        public void PreOrder(Node parent)
        {
            if (parent != null)
            {
                Console.Write(parent.Data + " ");
                PreOrder(parent.LeftNode);
                PreOrder(parent.RightNode);
            }
        }

        public void InOrder(Node parent)
        {
            if (parent != null)
            {
                InOrder(parent.LeftNode);
                Console.Write(parent.Data + " ");
                InOrder(parent.RightNode);
            }
        }

        public void PostOrder(Node parent)
        {
            if (parent != null)
            {
                PostOrder(parent.LeftNode);
                PostOrder(parent.RightNode);
                Console.Write(parent.Data + " ");
            }
        }
    }
}
