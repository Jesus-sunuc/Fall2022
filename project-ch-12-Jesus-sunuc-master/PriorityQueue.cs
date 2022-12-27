// This program allows the user to insert, delete, check if it is empty, and exit if the user select the options. This is priority queue using an array-based implementation.
// Author: Jesus Sunuc
// Date: 11/30/2022


using System;
using System.Collections.Generic;
using System.Text;
namespace Chapter_12_Project
{
    public class PriorityQueue<T> : PQueueInterface<T>
    {
        
        const int MAX_QUEUE = 100; //Constance that tell how is the boundary of the array
        private double[] queue = new double[MAX_QUEUE];//Create a queue based on a array to be maxqueue size
        private int size = 0; // This is goint to count the number of items.

        public bool isEmpty() // This method check if the array is empty.
        {
            if (size == 0)
            {
                return true; // if the size is 0 then return true
            }
            else
            {
                return false; // if the size is not 0 then return false
            }
        }
        public void insert(double newItem)
        {

            if (size == MAX_QUEUE) // If the size is equal to max (100) is going to print an execption.
            {
                throw new Exception("The queue is already full.");
            }
            else
            {
                int index = size; // Set the index to be the size of the array.
                while (index > 0 && queue[index - 1] > newItem) // While the index is greater than 0 and the item in the array is greater than the new item.
                {
                    queue[index] = queue[index - 1]; // The item in the array is going to be the item in the array -1.
                    index--; // Decrease the index by 1.
                }
                queue[index] = newItem; // Put the value in index
                size++; // Increase the size by 1.
            }
        }
        public T delete() // This method is going to delete the last item in the array.
        {
            queue[size - 1] = queue[size]; // Select the value of the last index and set to be the previous value
            size--;
            return default(T);
        }
        public void Display() // This method is going to display the results.
        {
            for (int i = 0; i < size; i++) 
            {
                Console.WriteLine("************************************");
                Console.WriteLine($"**     NUMBER {queue[i]} IS INSERTED     **"); // Print the message.
                Console.WriteLine("************************************");
            }
        }
    }
}

