// This program demonstrates the use of the different types of sorting. It allows the user to enter a list of numbers and then sorts them in ascending order.
// Author: Jesus Sunuc
// Date: 10/29/2022

namespace Lab10;
public static class SelectionSort
{
    public static void selectionSort<T>(T[] theArray, int n)
   where T : IComparable<T>
    {
        // ---------------------------------------------------
        // Sorts the items in an array into ascending order.
        // Precondition: theArray is an array of n items.
        // Postcondition: theArray is sorted into
        // ascending order.
        // Calls: indexOfLargest.
        // ---------------------------------------------------
        // last = index of the last item in the subarray of
        //        items yet to be sorted
        // largest = index of the largest item found
        for (int last = n - 1; last >= 1; last--)
        {
            // Invariant: theArray[last+1..n-1] is sorted
            // and > theArray[0..last]
            // select largest item in theArray[0..last]
            int largest = indexOfLargest(theArray, last + 1);
            // swap largest item theArray[largest] with
            // theArray[last]
            T temp = theArray[largest];
            theArray[largest] = theArray[last];
            theArray[last] = temp;
        }  // end for
    }  // end selectionSort

    private static int indexOfLargest<T>(T[] theArray, int size)
    where T : IComparable<T>
    {
        // ---------------------------------------------------
        // Finds the largest item in an array.
        // Precondition: theArray is an array of size items;
        // size >= 1.
        // Postcondition: Returns the index of the largest
        // item in the array.
        // ---------------------------------------------------
        int indexSoFar = 0; // index of largest item found so far
                            // Invariant: theArray[indexSoFar]>=theArray[0..currIndex-1]
        for (int currIndex = 1; currIndex < size; ++currIndex)
        {
            if (theArray[currIndex].CompareTo(theArray[indexSoFar]) > 0)
            {
                indexSoFar = currIndex;
            }  // end if
        } // end for
        return indexSoFar;  // index of largest item
    }  // end indexOfLargest
}