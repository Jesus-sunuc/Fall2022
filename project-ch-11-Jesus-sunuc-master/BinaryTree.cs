//This is a program that guess a animal by using recursive method.
// By Garth Sorenson

using System;
using System.Collections.Generic;
using System.Text;

namespace LearningTree
{
    class BinaryTree<T> : BinaryTreeBasis<T>
    {
        public BinaryTree()
        {
        }  // end default constructor

        public BinaryTree(T rootItem) : base(rootItem)
        {
        }  // end constructor

        public BinaryTree(T rootItem,
                          BinaryTree<T> leftTree,
                          BinaryTree<T> rightTree)
        {
            root = new TreeNode<T>(rootItem, null, null);
            attachLeftSubtree(leftTree);
            attachRightSubtree(rightTree);
        }  // end constructor

        public override void setRootItem(T newItem)
        {
            if (root != null)
            {
                root.Item = newItem;
            }
            else
            {
                root = new TreeNode<T>(newItem, null, null);
            }  // end if
        }  // end setRootItem

        public void attachLeft(T newItem)
        {
            if (!isEmpty() && root.LeftChild == null)
            {
                // assertion: nonempty tree; no left child
                root.LeftChild = new TreeNode<T>(newItem, null, null);
            }  // end if
        }  // end attachLeft

        public void attachRight(T newItem)
        {
            if (!isEmpty() && root.RightChild == null)
            {
                // assertion: nonempty tree; no right child
                root.RightChild = new TreeNode<T>(newItem, null, null);
            }  // end if
        }  // end attachRight

        public void attachLeftSubtree(BinaryTree<T> leftTree)
        {
            if (isEmpty()) {
                throw new TreeException("TreeException:  Empty tree");
            }
            else if (root.LeftChild != null) {
                // a left subtree already exists; it should have been
                // deleted first
                throw new TreeException("TreeException: " +
                    "Cannot overwrite left subtree");
            }
            else
            {
                // assertion: nonempty tree; no left child
                root.LeftChild = leftTree.root;
                // don't want to leave multiple entry points into
                // our tree
                leftTree.makeEmpty();
            }  // end if
        }  // end attachLeftSubtree
        
        public void attachRightSubtree(BinaryTree<T> rightTree)
        {
            if (isEmpty()) {
                throw new TreeException("TreeException:  Empty tree");
            }
            else if (root.RightChild != null) {
                // a right subtree already exists; it should have been
                // deleted first
                throw new TreeException("TreeException: " +
                    "Cannot overwrite right subtree");
            }
            else {
                // assertion: nonempty tree; no right child
                root.RightChild = rightTree.root;
                // don't want to leave multiple entry points into
                // our tree
                rightTree.makeEmpty();
            }  // end if
        }  // end attachRightSubtree
        
        protected BinaryTree(TreeNode<T> rootNode)
        {
            root = rootNode;
        }  // end protected constructor
        
        public BinaryTree<T> detachLeftSubtree()
        {
            if (isEmpty()) {
                throw new TreeException("TreeException:  Empty tree");
            }
            else {
                // create a new binary tree that has root's left
                // node as its root
                BinaryTree<T> leftTree;
                leftTree = new BinaryTree<T>(root.LeftChild);
                root.LeftChild = null;
                return leftTree;
            }  // end if
        }  // end detachLeftSubtree
        
        public BinaryTree<T> detachRightSubtree()
        {
            if (isEmpty()) {
                throw new TreeException("TreeException:  Empty tree");
            }
            else {
                BinaryTree<T> rightTree;
                rightTree = new BinaryTree<T>(root.RightChild);
                root.RightChild = null;
                return rightTree;
            }  // end if
        }  // end detachRightSubtree
    }
}
