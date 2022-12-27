// ListInterface.cs contains code from the Java textbook by Carrano.
// Translated to C# by Garth Sorenson
// 15 Sep 2021
// Eddited by Jesus Sunuc
// 20 Oct 2022

using System;

namespace ProjCh7
{
    public class ListIndexOutOfBoundsException : System.Exception
    {
        public ListIndexOutOfBoundsException(String s) : base(s)
        {
        }  // end constructor
    }  // end ListIndexOutOfBoundsException

    interface ListInterface
    {
        public bool isEmpty(); // Returns true if this list contains no elements.
        public int size(); // Returns the number of elements in this list.
        public void add(int index, City item); // Inserts the specified element at the specified position in this list.
        public City get(int index); // Returns the element at the specified position in this list.
        public void remove(int index); // Removes the element at the specified position in this list.
        public void removeAll(); // Removes all of the elements from this list.

    }
}