/*
Name: Jesus Sunuc
Date: 09/15/2022
// Description: The user will enter some numbers and the program will display a polynial, if the user enter a value for x, the program will display the result of the polynomial.
*/
namespace classes;
using System.Diagnostics;
using System;
class Program
{
    // This is the main method.
    static void Main(string[] args)
    {
        Greetings(); // Call the Greetings method.

        string input = Console.ReadLine(); // Read the input from the console.
        int n = int.Parse(input);
        double[] a = new double[++n]; // Create an array of doubles with n+1 elements

        for (int i = 0; i < n; i++) // Read the coefficients from the console
        {
            Console.Write("Coefficient for x^" + i + " = "); // Write the message to the console
            a[i] = double.Parse(Console.ReadLine()); // Read the input from the console
        }

        Console.WriteLine();
        Console.WriteLine("Here is your polynomial: " + Polynomial.toString(a)); // Write the message to the console and call the toString method from the Polynomial class.
        Console.WriteLine();

        Console.Write("Enter the value for x : "); // Write the message to the console
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("The result is : ");
        Console.Write(Polynomial.horner(a, x)); // Write the result of the horner method from the Polynomial class.
        Console.WriteLine();
        Tests(); // Call the Tests method.
    }

    static void Tests() // This is the test method.
    {
        double[] a = { 1, 2, 3, 4, 5 };
        double x = 2;
        Debug.Assert(Polynomial.horner(a, x) == 57);
        Debug.Assert(Polynomial.toString(a) == "1x^0 + 2x^1 + 3x^2 + 4x^3 + 5x^4 + ");
        Console.WriteLine("Tests passed");
    }

    // This is the Greetings method
    static void Greetings()
    {
        Console.WriteLine("Please enter the polynomial you wish to work with.");
        Console.WriteLine("You will be prompted to enter the coeffient for each term in the polynomial.");
        Console.WriteLine("You may enter zero if the term is absent from the polynomial.");
        Console.WriteLine("Enter the degree of your polynomial: ");
    }
}