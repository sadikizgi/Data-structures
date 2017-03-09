using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VYL02112016
{
    class BinarySearchTree<T> where T :IComparable
    {
        BSTNode<T> root;

        public void Add(T val)
        {

            if (root == null)
                root = new BSTNode<T>(val);
            else
            {
                BSTNode<T> iterator =root, parent = root;

                while (iterator != null)
                {
                    parent = iterator;
                    if (iterator.Value.CompareTo(val) == 1)
                        iterator = iterator.Left;
                    else
                        iterator = iterator.Right;
                    //iterator = iterator.Value.CompareTo(val) == 1 ? iterator.Left : iterator.Right;
                }
                if (parent.Value.CompareTo(val) == 1)
                    parent.Left = new BSTNode<T>(val);
                else
                    parent.Right = new BSTNode<T>(val);

            }
        }

        public void InOrder()
        {
            InOrder(root);
        }
        private void InOrder(BSTNode<T> tempRoot)
        {
            if (tempRoot != null)
            {
                InOrder(tempRoot.Left);
                Console.WriteLine(tempRoot.Value);
                InOrder(tempRoot.Right);

            }

        }
        public void PreOrder()
        {
            PreOrder(root);
        }
        private void PreOrder(BSTNode<T> tempRoot)
        {
            if (tempRoot != null)
            {
                Console.WriteLine(tempRoot.Value);
                PreOrder(tempRoot.Left);
                PreOrder(tempRoot.Right);

            }

        }
        public void PostOrder()
        {
            PostOrder(root);
        }
        private void PostOrder(BSTNode<T> tempRoot)
        {
            if (tempRoot != null)
            {
                
                PostOrder(tempRoot.Left);
                PostOrder(tempRoot.Right);
                Console.WriteLine(tempRoot.Value);

            }

        }

        public bool Search(T val)
        {
            BSTNode<T> iterator = root;

            while (iterator != null)
            {
                if (iterator.Value.CompareTo(val) == 0)
                    return true;
                else if (iterator.Value.CompareTo(val) == 1)
                    iterator = iterator.Left;
                else
                    iterator = iterator.Right;
            }
            return false;
        }

        //derste yazilacak
        public BSTNode<T> findMinNode(BSTNode<T> tempRoot)
        {
            if (tempRoot == null)
                return default(BSTNode<T>);

            BSTNode<T> iterator = tempRoot;
            while (iterator.Left != null)
                iterator = iterator.Left;
            return iterator;
        }

        public T findMin()
        {
            if (root == null)
                return default(T);
            BSTNode<T> iterator = root;
            while (iterator.Left != null)
                iterator = iterator.Left;
            return iterator.Value;

        }

        public T findMax()
        {
            if (root == null)
                return default(T);
            BSTNode<T> iterator = root;
            while (iterator.Right != null)
                iterator = iterator.Right;
            return iterator.Value;

        }

        public BSTNode<T> FindNode(T val)
        {
            if (root == null)
                return null;
            BSTNode<T> iterator = root;
            while (iterator != null)
            {
                if (iterator.Value.CompareTo(val) == 0)
                    return iterator;
                else if (iterator.Value.CompareTo(val) == 1)
                    iterator = iterator.Left;
                else
                    iterator = iterator.Right;
            }
            return null;
        }

        public int NodeCount()
        {
           return NodeCount(root);
        }

        private int NodeCount(BSTNode<T> tempRoot)
        {
            if (tempRoot == null)
                return 0;
            return NodeCount(tempRoot.Left) + 1 + NodeCount(tempRoot.Right);
        }

        public BSTNode<T> findParent(T val)
        {
            if (!Search(val) || root.Value.CompareTo(val)==0)
                return null;
            BSTNode<T> iterator=root, parent=root;
            while (iterator.Value.CompareTo(val) != 0)
            {
                parent = iterator;
                if (iterator.Value.CompareTo(val) == 1)
                {
                    //parent = iterator;
                    iterator = iterator.Left;
                }
                else
                {
                    //parent = iterator;
                    iterator = iterator.Right;
                }
            }
            return parent;

        }

    }
}
