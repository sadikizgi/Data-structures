using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VYL23112016
{
    class BinarySearchTree<T> where T : IComparable
    {
        BSTNode<T> root;

        public void Add(T val)
        {
            BSTNode<T> newNode = new BSTNode<T>(val);
            if (root == null)
                root = newNode;
            else
                root = RecursiveInsert(root, newNode);
        }
        private BSTNode<T> RecursiveInsert(BSTNode<T> tempRoot, BSTNode<T> n)
        {
            if (tempRoot == null)
            {
                tempRoot = n;
                return tempRoot;
            }
            else if (n.Value.CompareTo(tempRoot.Value) == -1)
            {
                tempRoot.Left = RecursiveInsert(tempRoot.Left, n);
                tempRoot = BalanceTree(tempRoot);
            }
            else if (n.Value.CompareTo(tempRoot.Value) == 1)
            {
                tempRoot.Right = RecursiveInsert(tempRoot.Right, n);
                tempRoot = BalanceTree(tempRoot);
            }
            return tempRoot;
        }

        private BSTNode<T> BalanceTree(BSTNode<T> tempRoot)
        {
            int bFactor = BalanceFactor(tempRoot);
            if (bFactor > 1)
            {
                if (BalanceFactor(tempRoot.Left) > 0)
                    tempRoot = RotateLL(tempRoot);
                else
                    tempRoot = RotateLR(tempRoot);
            }
            else if (bFactor < -1)
            {
                if (BalanceFactor(tempRoot.Right) > 0)
                    tempRoot = RotateRL(tempRoot);
                else
                    tempRoot = RotateRR(tempRoot);
            }
            return tempRoot;
        }
        private int BalanceFactor(BSTNode<T> tempRoot)
        {
            int l = getHeight(tempRoot.Left);
            int r = getHeight(tempRoot.Right);
            int bFactor = l - r;
            return bFactor;
        }
        private int getHeight(BSTNode<T> tempRoot)
        {
            int height = 0;
            if (tempRoot != null)
            {
                int l = getHeight(tempRoot.Left);
                int r = getHeight(tempRoot.Right);
                int m = max(l, r);
                height = m + 1;
            }
            return height;
        }
        private int max(int l, int r)
        {
            return l > r ? l : r;
        }
        private BSTNode<T> RotateRR(BSTNode<T> parent)
        {
            BSTNode<T> pivot = parent.Right;
            parent.Right = pivot.Left;
            pivot.Left = parent;
            return pivot;
        }
        private BSTNode<T> RotateLL(BSTNode<T> parent)
        {
            BSTNode<T> pivot = parent.Left;
            parent.Left = pivot.Right;
            pivot.Right = parent;
            return pivot;
        }
        private BSTNode<T> RotateLR(BSTNode<T> parent)
        {
            BSTNode<T> pivot = parent.Left;
            parent.Left = RotateRR(pivot);
            return RotateLL(parent);
        }
        private BSTNode<T> RotateRL(BSTNode<T> parent)
        {
            BSTNode<T> pivot = parent.Right;
            parent.Right = RotateLL(pivot);
            return RotateRR(parent);
        }
        public void DisplayTree()
        {
            if (root == null)
            {
                Console.WriteLine("Tree is empty");
                return;
            }
            InOrderDisplayTree(root);
            Console.WriteLine();
        }
        private void InOrderDisplayTree(BSTNode<T> tempRoot)
        {
            if (tempRoot != null)
            {
                InOrderDisplayTree(tempRoot.Left);
                Console.Write("({0}) ", tempRoot.Value);
                InOrderDisplayTree(tempRoot.Right);
            }
        }
    }
}
