using System;
using System.Collections;
using System.Collections.Generic;

namespace BinarySearchTrees
{
    public class BinaryTree
    {
        public Node Root { get; set; }

        public static BinaryTree binaryTree = new();

        public static Queue<Node> queue = new();

        public static BinaryTree GetAllInTree()
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

        public Node Search(int value)
        {
            return Search(value, Root);
        }

        public Node Search(int value, Node parent)
        {
            if (parent != null)
            {
                if (value == parent.Data)
                {
                    return parent;
                }
                if (value < parent.Data)
                {
                    return Search(value, parent.LeftNode);
                }
                else
                {
                    return Search(value, parent.RightNode);
                }
            }
            return null;
        }

        public void Remove(int value)
        {
            Root = Remove(Root, value);

        }

        public Node Remove(Node parent, int key)
        {
            if (parent == null)
            {
                return parent;
            }
            if (key < parent.Data)
            {
                parent.LeftNode = Remove(parent.LeftNode, key);
            }
            else if (key > parent.Data)
            {
                parent.RightNode = Remove(parent.RightNode, key);
            }
            else
            {
                if (parent.LeftNode == null)
                {
                    return parent.RightNode;
                }
                else if (parent.RightNode == null)
                {
                    return parent.LeftNode;
                }
                parent.Data = MinValue(parent.RightNode);
                parent.RightNode = Remove(parent.RightNode, parent.Data);
            }
            return parent;
        }

        public static int MinValue(Node node)
        {
            int minv = node.Data;

            while (node.LeftNode != null)
            {
                minv = node.LeftNode.Data;
                node = node.LeftNode;
            }

            return minv;
        }


        public int GetTreeDepth()
        {
            return GetTreeDepth(Root);
        }

        public int GetTreeDepth(Node parent)
        {
            return parent == null ? 0 : Math.Max(GetTreeDepth(parent.LeftNode), GetTreeDepth(parent.RightNode)) + 1;
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
