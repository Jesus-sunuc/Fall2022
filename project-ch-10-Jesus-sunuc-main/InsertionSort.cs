// This program demonstrates the use of the different types of sorting. It allows the user to enter a list of numbers and then sorts them in ascending order.
// Author: Jesus Sunuc
// Date: 10/29/2022

namespace Lab10;
public static class InsertionSort
{
    public static void insertionSort<T>(T[] theArray, int n)
    where T : IComparable<T>
    {
        // ---------------------------------------------------
        // Sorts the items in an array into ascending order.
        // Precondition: theArray is an array of n items.
        // Postcondition: theArray is sorted into ascending
        // order.
        // ---------------------------------------------------
        // unsorted = first index of the unsorted region,
        // loc = index of insertion in the sorted region,
        // nextItem = next item in the unsorted region
        // initially, sorted region is theArray[0],
        //          unsorted region is theArray[1..n-1];
        // in general, sorted region is theArray[0..unsorted-1],
        //          unsorted region is theArray[unsorted..n-1]
        for (int unsorted = 1; unsorted < n; ++unsorted)
        {
            // Invariant: theArray[0..unsorted-1] is sorted
            // find the right position (loc) in
            // theArray[0..unsorted] for theArray[unsorted],
            // which is the first item in the unsorted
            // region; shift, if necessary, to make room
            T nextItem = theArray[unsorted];
            int loc = unsorted;
            while ((loc > 0) &&
                   (theArray[loc - 1].CompareTo(nextItem) > 0))
            {
                // shift theArray[loc-1] to the right
                theArray[loc] = theArray[loc - 1];
                loc--;
            }  // end while
               // Assertion: theArray[loc] is where nextItem belongs
               // insert nextItem into sorted region
            theArray[loc] = nextItem;
        }  // end for
    }  // end insertionSort
}