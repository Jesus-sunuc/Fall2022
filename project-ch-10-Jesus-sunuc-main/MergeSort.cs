// This program demonstrates the use of the different types of sorting. It allows the user to enter a list of numbers and then sorts them in ascending order.
// Author: Jesus Sunuc
// Date: 10/29/2022

namespace Lab10;
public static class MergeSort
{
    public static void mergeSort<T>(T[] theArray, int n)
    where T : IComparable<T>
    {
        // ---------------------------------------------------
        // Sorts the items in an array into ascending order.
        // Precondition: theArray is an array of n items.
        // Postcondition: theArray is sorted into ascending
        // order.
        // ---------------------------------------------------
        // Declare temporary array used for merge, must do
        // unchecked cast from Comparable<?>[] to T[]
        T[] tempArray = new T[n];
        mergesort(theArray, tempArray, 0, theArray.Length - 1);
    } // end mergesort
    private static void merge<T>(T[] theArray, T[] tempArray,
               int first, int mid, int last)
        where T : IComparable<T>
    {
        // ---------------------------------------------------------
        // Merges two sorted array segments theArray[first..mid] and
        // theArray[mid+1..last] into one sorted array.
        // Precondition: first <= mid <= last. The subarrays
        // theArray[first..mid] and theArray[mid+1..last] are
        // each sorted in increasing order.
        // Postcondition: theArray[first..last] is sorted.
        // Implementation note: This method merges the two
        // subarrays into a temporary array and copies the result
        // into the original array theArray.
        // ---------------------------------------------------------
        // initialize the local indexes to indicate the subarrays
        int first1 = first;    // beginning of first subarray
        int last1 = mid;      // end of first subarray
        int first2 = mid + 1;  // beginning of second subarray
        int last2 = last;     // end of second subarray
                              // while both subarrays are not empty, copy the
                              // smaller item into the temporary array
        int index = first1;    // next available location in
                               // tempArray
        while ((first1 <= last1) && (first2 <= last2))
        {
            // Invariant: tempArray[first1..index-1] is in order
            if (theArray[first1].CompareTo(theArray[first2]) < 0)
            {
                tempArray[index] = theArray[first1];
                first1++;
            }
            else
            {
                tempArray[index] = theArray[first2];
                first2++;
            }  // end if
            index++;
        }  // end while
           // finish off the nonempty subarray
           // finish off the first subarray, if necessary
        while (first1 <= last1)
        {
            // Invariant: tempArray[first1..index-1] is in order
            tempArray[index] = theArray[first1];
            first1++;
            index++;
        }  // end while
           // finish off the second subarray, if necessary
        while (first2 <= last2)
        {
            // Invariant: tempArray[first1..index-1] is in order
            tempArray[index] = theArray[first2];
            first2++;
            index++;
        }  // end while
           // copy the result back into the original array
        for (index = first; index <= last; ++index)
        {
            theArray[index] = tempArray[index];
        }  // end for
    }  // end merge
    private static void mergesort<T>(T[] theArray, T[] tempArray,
                  int first, int last)
        where T : IComparable<T>
    {
        // ---------------------------------------------------------
        // Sorts the items in an array into ascending order.
        // Precondition: theArray[first..last] is an array.
        // Postcondition: theArray[first..last] is sorted in
        // ascending order.
        // Calls: merge.
        // ---------------------------------------------------------
        if (first < last)
        {
            // sort each half
            int mid = (first + last) / 2;   // index of midpoint
                                            // sort left half theArray[first..mid]
            mergesort(theArray, tempArray, first, mid);
            // sort right half theArray[mid+1..last]
            mergesort(theArray, tempArray, mid + 1, last);
            // merge the two halves
            merge(theArray, tempArray, first, mid, last);
        }  // end if
    }  // end mergesort
}