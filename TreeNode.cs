using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureNonLinear
{
    internal class TreeNode
    {
        internal int value;
        public  TreeNode left;
       public  TreeNode right;
        
    }

    internal class Tree
    {
        internal TreeNode root;
        public Tree(TreeNode root)
        {
            root = null;
        }

        public Tree()
        {
        }

        public TreeNode returnRoot()
        {
            return root;
        }
        
        public void Insert(int data)
        {
            TreeNode t = new TreeNode();
            t.value = data;
            if (root == null)
            {
                root = t;
            }
            else
            {
                TreeNode current = root;
                TreeNode parent;
                while (true)
                {
                    parent = current;
                    if (data < current.value)
                    {
                        current = current.left;
                        if (current == null)
                        {
                            parent.left = t;
                            return;
                        }
                    }
                    else
                    {
                        current=current.right;
                        if(current == null)
                        {
                            parent.right = t;
                            return;
                        }
                    }
               
                }

            }

           
        }
        public void Pre_order(TreeNode root)
        {
            if (root != null)
            {
                Console.WriteLine(root.value+" ");
                Pre_order(root.left);
                Pre_order(root.right);
            }
        }
        public void In_order(TreeNode root)
        {
            if (root != null)
            {
                
                Pre_order(root.left);
                Console.WriteLine(root.value + " ");
                Pre_order(root.right);
            }
        }
        public void Post_order(TreeNode root)
        {
            if (root != null)
            {

                Pre_order(root.left);
                Pre_order(root.right);
                Console.WriteLine(root.value + " ");
            }
        }
    }
}
