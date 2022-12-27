//This is a program that guess a animal by using recursive method.
// By Garth Sorenson


using System;
using System.Collections.Generic;
using System.Text;

namespace LearningTree
{
    abstract class BinaryTreeBasis<T>
    {
        protected TreeNode<T> root;

        public BinaryTreeBasis()
        {
            root = null;
        }  // end default constructor

        public BinaryTreeBasis(T rootItem)
        {
            root = new TreeNode<T>(rootItem, null, null);
        }  // end constructor

        public bool isEmpty()
        {
            // Returns true if the tree is empty, else returns false.
            return root == null;
        }  // end isEmpty

        public void makeEmpty()
        {
            // Removes all nodes from the tree.
            root = null;
        }  // end makeEmpty

        public T getRootItem()
        {
            // Returns the item in the tree's root.
            if (root == null) {
                throw new TreeException("TreeException: Empty tree");
            }
            else {
                return root.Item;
            }  // end if
        }  // end getRootItem
        
        public abstract void setRootItem(T newItem);
        // Throws UnsupportedOperationException if operation
        // is not supported.
    }
}
