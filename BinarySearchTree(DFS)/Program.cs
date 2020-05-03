using System;
using System.Collections.Generic;

namespace BinarySearchTree_DFS_
{
    // DFS for a binary searcch tree
    // We have multiple ways to search the tree: Preorder, Inorder, and Postorder.

    // Preorder search pattern:
    //                  1
    //                 / \
    //                2   5
    //               / \
    //              3   4

    // Inorder search pattern:
    //                  4
    //                 / \
    //                2   5
    //               / \
    //              1   3

    // Posrorder search pattern:
    //                  5
    //                 / \
    //                3   4
    //               / \
    //              1   2

    // Definition for a binary tree node:
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x)
        {
            val = x;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // This Tree will look like this:
            //                  50
            //                 /  \
            //                30  60
            //               /  \
            //              20  40
            //             /
            //            10

            TreeNode root = new TreeNode(50);
            root.left = new TreeNode(30);
            root.right = new TreeNode(60);
            root.left.left = new TreeNode(20);
            root.left.right = new TreeNode(40);
            root.right.left = null;
            root.right.right = null;
            root.left.left.left = new TreeNode(10);

            Console.WriteLine("InOrder: ");
            // InOrder should return 10-20-30-40-50-60
            foreach(var item in InOrder(root, new List<int>()))
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("PreOrder: ");
            // PreOrder should return 50-30-20-10-40-60
            foreach (var item in PreOrder(root, new List<int>()))
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("PostOrder: ");
            //PostOrder should return 10-20-40-30-60-50
            foreach (var item in PostOrder(root, new List<int>()))
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        static List<int> InOrder(TreeNode root, List<int> arr)
        {
            if(root == null)
            {
                return arr;
            }
            InOrder(root.left, arr);
            arr.Add(root.val);
            InOrder(root.right, arr);
            return arr;
        }

        static List<int> PreOrder(TreeNode root, List<int> arr)
        {
            if (root == null)
            {
                return arr;
            }
            arr.Add(root.val);
            PreOrder(root.left, arr);
            PreOrder(root.right, arr);
            return arr;
        }
        static List<int> PostOrder(TreeNode root, List<int> arr)
        {
            if (root == null)
            {
                return arr;
            }
            PostOrder(root.left, arr);
            PostOrder(root.right, arr);
            arr.Add(root.val);
            return arr;
        }
    }
}
