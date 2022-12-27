// This program demonstrates the use of the different types of sorting. It allows the user to enter a list of numbers and then sorts them in ascending order.
// Author: Jesus Sunuc
// Date: 10/29/2022

namespace Lab10;
public static class BubbleSort
{
    public static void bubbleSort<T>(T[] theArray, int n)
        where T : IComparable<T>
    {
        // ---------------------------------------------------
        // Sorts the items in an array into ascending order.
        // Precondition: theArray is an array of n items.
        // Postcondition: theArray is sorted into ascending
        // order.
        // ---------------------------------------------------
        bool sorted = false;  // false when swaps occur
        for (int pass = 1; (pass < n) && !sorted; ++pass)
        {
            // Invariant: theArray[n+1-pass..n-1] is sorted
            //            and > theArray[0..n-pass]
            sorted = true;  // assume sorted
            for (int index = 0; index < n - pass; ++index)
            {
                // Invariant: theArray[0..index-1] <= theArray[index]
                int nextIndex = index + 1;
                if (theArray[index].CompareTo(theArray[nextIndex]) > 0)
                {
                    // exchange items
                    T temp = theArray[index];
                    theArray[index] = theArray[nextIndex];
                    theArray[nextIndex] = temp;
                    sorted = false;  // signal exchange
                }  // end if
            }  // end for
               // Assertion: theArray[0..n-pass-1] < theArray[n-pass]
        }  // end for
    }  // end bubbleSort
}