// This program allows the user to insert, delete, check if it is empty, and exit if the user select the options. This is priority queue using an array-based implementation.
// Author: Jesus Sunuc
// Date: 11/30/2022


using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter_12_Project
{
    class Program
    {
        static void Main(string[] args) // This main method is going to allow the user to se
        {
            bool check = true; // This is going to check if the user want to continue or not.
            {
                //Print a Greeting to the user
                Console.WriteLine("Welcome to this program, it is going to allow you to insert, and delete numbers in a priority queue.");
                Console.WriteLine();
                PriorityQueue<double> priority = new PriorityQueue<double>(); // Create a new object of the priority queue.
                while (check == true) // While the check is true.
                {
                    Console.WriteLine();
                    Console.WriteLine("Please select one of the following options: ");
                    Console.WriteLine("number 1 to insert, number 2 to delete, number 3 to check if it is empty, number 4 to exit.");
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("1. Insert an item to the queue");
                    Console.WriteLine("2. Delete an item from the queue");
                    Console.WriteLine("3. Check if the queue is empty");
                    Console.WriteLine("4. Exit");
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("Please select an option: ");
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine();
                    
                    int option = Convert.ToInt32(Console.ReadLine()); // This is going to read the option that the user select.
                    switch (option)
                    {
                        case 1: // If the user select 1.
                            Console.WriteLine();
                            Console.WriteLine("Please insert a number."); // Ask the user to enter a item.
                            Console.WriteLine();
                            double newItem = double.Parse(Console.ReadLine());    // Read the item.
                            priority.insert(newItem); // Insert the item.
                            priority.Display(); // Display the results.
                            break;

                        case 2:
                            priority.delete(); // Delete the last item in the array.
                            priority.Display(); // Display the results.
                            break;

                        case 3:
                            check = false; // If the user select 3 then the check is going to be false.
                            break;

                        case 4:
                            if (priority.isEmpty()) // If the priority queue is empty.
                            {
                                Console.WriteLine("The queue is empty\n"); // Print the message.
                                Console.Clear(); // Clear the console.
                                // priority.Display(); // Display the results.
                            }

                            Console.WriteLine("The queue is not empty\n"); // If the priority queue is not empty.
                            Console.Clear(); // Clear the console.
                            break;

                        default:
                            Console.WriteLine("Please select a valid option"); // If the user select a invalid option.
                            break;
                    }
                }
            }
        }
    }
}