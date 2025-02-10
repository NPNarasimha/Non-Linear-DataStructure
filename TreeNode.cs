using System;
using System.Collections.Generic;
using System.Text;
using Aardvark.Base;

namespace DataStructureNonLinear
{
    internal class TreeNode
    {
        public int value;
        public TreeNode left, right;

        // Constructor for TreeNode
        public TreeNode(int data)
        {
            value = data;
            left = right = null;
        }
    }

    internal class Tree
    {
        public TreeNode root;

        public Tree()
        {
            root = null;
        }

        public TreeNode ReturnRoot()
        {
            return root;
        }

        public void Insert(int data)
        {
            TreeNode newNode = new TreeNode(data);

            if (root == null)
            {
                root = newNode;
                return;
            }

            TreeNode current = root;
            TreeNode parent = null;

            while (current != null)
            {
                parent = current;
                if (data < current.value)
                {
                    current = current.left;
                    if (current == null)
                    {
                        parent.left = newNode;
                        return;
                    }
                }
                else
                {
                    current = current.right;
                    if (current == null)
                    {
                        parent.right = newNode;
                        return;
                    }
                }
            }
        }

        public void PreOrder(TreeNode root)
        {
            if (root != null)
            {
                Console.Write(root.value + " ");
                PreOrder(root.left);
                PreOrder(root.right);
            }
        }

        public void InOrder(TreeNode root)
        {
            if (root != null)
            {
                InOrder(root.left);
                Console.Write(root.value + " ");
                InOrder(root.right);
            }
        }

        public void PostOrder(TreeNode root)
        {
            if (root != null)
            {
                PostOrder(root.left);
                PostOrder(root.right);
                Console.Write(root.value + " ");
            }
        }
    }
}
