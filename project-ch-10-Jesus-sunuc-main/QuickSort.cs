// This program demonstrates the use of the different types of sorting. It allows the user to enter a list of numbers and then sorts them in ascending order.
// Author: Jesus Sunuc
// Date: 10/29/2022

namespace Lab10;
public static class QuickSort
{
    private static void choosePivot<T>(T[] theArray, int first, int last)
    where T : IComparable<T>
    {
        // ---------------------------------------------------------
        // Chooses a pivot for quicksort's partition algorithm and
        // swaps it with the first item in an array.
        // Precondition: theArray[first..last] where first <= last.
        // Postcondition: theArray[first] is the pivot.
        // ---------------------------------------------------------
        // Implementation left as an exercise.
    }  // end choosePivot
    private static int partition<T>(T[] theArray, int first, int last)
        where T : IComparable<T>
    {
        // ---------------------------------------------------------
        // Partitions an array for quicksort.
        // Precondition: theArray[first..last] where first <= last.
        // Postcondition: Returns the index of the pivot element of
        // theArray[first..last]. Upon completion of the method,
        // this will be the index value lastS1 such that
        //    S1 = theArray[first..lastS1-1] <  pivot
        //         theArray[lastS1]          == pivot
        //    S2 = theArray[lastS1+1..last]  >= pivot
        // Calls: choosePivot.
        // ---------------------------------------------------------
        // tempItem is used to swap elements in the array
        T tempItem;
        // place pivot in theArray[first]
        choosePivot(theArray, first, last);
        T pivot = theArray[first];   // reference pivot
                                     // initially, everything but pivot is in unknown
        int lastS1 = first;          // index of last item in S1
                                     // move one item at a time until unknown region is empty
                                     // firstUnknown is the index of first item in unknown region
        for (int firstUnknown = first + 1; firstUnknown <= last;
                                          ++firstUnknown)
        {
            // Invariant: theArray[first+1..lastS1] < pivot
            //            theArray[lastS1+1..firstUnknown-1] >= pivot
            // move item from unknown to proper region
            if (theArray[firstUnknown].CompareTo(pivot) < 0)
            {
                // item from unknown belongs in S1
                ++lastS1;
                tempItem = theArray[firstUnknown];
                theArray[firstUnknown] = theArray[lastS1];
                theArray[lastS1] = tempItem;
            }  // end if
               // else item from unknown belongs in S2
        }  // end for
           // place pivot in proper position and mark its location
        tempItem = theArray[first];
        theArray[first] = theArray[lastS1];
        theArray[lastS1] = tempItem;
        return lastS1;
    }  // end partition
    public static void quickSort<T>(T[] theArray, int n)
        where T : IComparable<T>
    {
        // ---------------------------------------------------
        // Sorts the items in an array into ascending order.
        // Precondition: theArray is an array of n items.
        // Postcondition: theArray is sorted into ascending
        // order.
        quickSort(theArray, 0, n - 1);
    }  // end quickSort
    private static void quickSort<T>(T[] theArray, int first, int last)
        where T : IComparable<T>
    {
        // ---------------------------------------------------------
        // Sorts the items in an array into ascending order.
        // Precondition: theArray[first..last] is an array.
        // Postcondition: theArray[first..last] is sorted.
        // Calls: partition.
        // ---------------------------------------------------------
        int pivotIndex;
        if (first < last)
        {
            // create the partition: S1, Pivot, S2
            pivotIndex = partition(theArray, first, last);
            // sort regions S1 and S2
            quickSort(theArray, first, pivotIndex - 1);
            quickSort(theArray, pivotIndex + 1, last);
        }  // end if
    }  // end quickSort
}