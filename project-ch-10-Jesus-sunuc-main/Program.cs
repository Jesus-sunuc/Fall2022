// This program demonstrates the use of the different types of sorting. It allows the user to enter a list of numbers and then sorts them in ascending order.
// Author: Jesus Sunuc
// Date: 10/29/2022

namespace Lab10;
using System.Diagnostics;

class Program
{
    static void Main() // Main method
    {
        Console.WriteLine("Welcome to this program that sorts an array of numbers in ascending order.");
        Console.WriteLine("Also, it is going to show you the results of the different types of sorting.");
        Console.WriteLine("");
        Console.WriteLine("Enter the number of elements in the array: ");
        int n = int.Parse(Console.ReadLine()); // Read the number of elements in the array
        int[] theArray = new int[n]; // Create the array

        Random rand = new Random(); // Create a random number generator

        for (int i = 0; i < n; i++)
        {
            theArray[i] = rand.Next(0, n); // Fill the array with random numbers.
        }

        foreach (var item in theArray) // Print the array
        {
            Console.Write(item + ", ");
        }
        
        // Print the time it takes to sort each array
        Console.WriteLine("\n");
        Console.WriteLine($"The sorted array is: [{string.Join(", ", theArray)}]");
        Console.Write($"The time for Selection Sort was: {selectionsort(theArray, n)} milliseconds.");
        Console.Write($"The time for Insertion Sort was: {insertionsort(theArray, n)} millisecons.");
        Console.Write($"The time for Bubble Sort was: {bubblesort(theArray, n)} millisecons.");
        Console.Write($"The time for Merge Sort was: {mergesort(theArray, n)} millisecons.");
        Console.Write($"The time for Quick Sort was: {quicksort(theArray, n)} millisecons.");
        Console.WriteLine("");
    }

    private static double selectionsort(int[] theArray, int n) // Selection Sort method
    {
        Console.WriteLine();
        Stopwatch sw = new Stopwatch(); // Create a stopwatch
        sw.Start(); // Start the stopwatch
        SelectionSort.selectionSort(theArray, n); // Call the selection sort method
        sw.Stop(); // Stop the stopwatch
        return sw.Elapsed.TotalMilliseconds / 1000.0; // Return the time it took to sort the array
    }

    private static double insertionsort(int[] theArray, int n) // Insertion Sort method.
    {
        Console.WriteLine();
        Stopwatch sw = new Stopwatch(); // Create a stopwatch
        sw.Start(); // Start the stopwatch
        InsertionSort.insertionSort(theArray, n); // Call the insertion sort method
        sw.Stop();  // Stop the stopwatch
        return sw.Elapsed.TotalMilliseconds / 1000.0; // Return the time it took to sort the array
    }

    private static double bubblesort(int[] theArray, int n) // Bubble Sort method
    {
        Console.WriteLine();
        Stopwatch sw = new Stopwatch(); // Create a stopwatch
        sw.Start(); // Start the stopwatch
        BubbleSort.bubbleSort(theArray, n); // Call the bubble sort method
        sw.Stop(); // Stop the stopwatch
        return sw.Elapsed.TotalMilliseconds / 1000.0; // Return the time it took to sort the array
    }

    private static double mergesort(int[] theArray, int n) // Merge Sort method.
    {
        Console.WriteLine();
        Stopwatch sw = new Stopwatch(); // Create a stopwatch
        sw.Start(); // Start the stopwatch
        MergeSort.mergeSort(theArray, n); 
        sw.Stop();  // Stop the stopwatch
        return sw.Elapsed.TotalMilliseconds / 1000.0;   // Return the time it took to sort the array
    }

    private static double quicksort(int[] theArray, int n) // Quick Sort method.
    {
        Console.WriteLine();
        Stopwatch sw = new Stopwatch(); // Create a stopwatch
        sw.Start(); // Start the stopwatch
        QuickSort.quickSort(theArray, n); // Call the quick sort method
        sw.Stop(); // Stop the stopwatch
        return sw.Elapsed.TotalMilliseconds / 1000.0;   // Return the time it took to sort the array.
    }
}