//This is a program that guess a animal by using recursive method.
// By Garth Sorenson

using System;
using System.Collections.Generic;
using System.Text;

namespace LearningTree
{
    class TreeNode<T>
    {
        T item;
        TreeNode<T> leftChild;
        TreeNode<T> rightChild;

        public T Item
        {
            get
            {
                return item;
            }
            set
            {
                item = value;
            }
        }

        public TreeNode<T> LeftChild
        {
            get
            {
                return leftChild;
            }
            set
            {
                leftChild = value;
            }
        }

        public TreeNode<T> RightChild
        {
            get
            {
                return rightChild;
            }
            set
            {
                rightChild = value; 
            }
        }

        public TreeNode(T newItem)
        {
            // Initializes tree node with item and no children.
            item = newItem;
            leftChild = null;
            rightChild = null;
        }

        public TreeNode(T newItem,
                        TreeNode<T> left, TreeNode<T> right)
        {
            // Initializes tree node with item and
            // the left and right children references.
            item = newItem;
            leftChild = left;
            rightChild = right;
        }  // end constructor

    }
}
