// This program allows the user to insert, delete, check if it is empty, and exit if the user select the options. This is priority queue using an array-based implementation.
// Author: Jesus Sunuc
// Date: 11/30/2022


using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter_12_Project
{
    public class PQueueException : System.Exception
    {
        public PQueueException(String s) : base(s)
        { }
    }
    public interface PQueueInterface<T>
    {
        public bool isEmpty();
        // Determines whether a priority queue is empty.
        // Postcondition: Returns true if the priority queue is
        // empty; otherwise returns false.

        public void insert(double newItem);
        // Inserts newItem into a priority queue. Throws
        // PQueueException if priority queue is full

        public T delete();
        // Retrieves and then deletes the item in a priority queue
        // with the highest priority value
    }
}
