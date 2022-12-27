/*
Name: Jesus Sunuc
Date: 10/01/2022
Description: The user will enter some numbers and the program will display a polynial, if the user enter a value for x, the program will display the result of the polynomial.
*/
namespace classes;
using System;

class Program
{
    // This is the main method.
    static void Main(string[] args)
    {
        Greetings(); // Call the Greetings method.

        Polynomial polynomial = new Polynomial(); // This is the object of the Polynomial class.

        int degree = int.Parse(Console.ReadLine());
        Console.WriteLine();

        Console.WriteLine("Please enter the coefficient of the polynomial: "); // Ask the user to enter the coefficient of the polynomial.
        double[] a = new double[degree + 1]; // This is the array of the coefficients.
        Console.WriteLine();

        for (int i = 0; i < (degree + 1); i++) // Read the coefficients from the console
        {
            Console.Write("Coefficient for x^" + i + " = "); // Write the message to the console
            a[i] = int.Parse(Console.ReadLine()); // Read the input from the console
        }

        Console.Write("The polynomial is: "); // display the polynomial
        for (int i = 0; i <= degree; i++)
        {
            polynomial.AddTerm(a[i], i);
        }
        polynomial.DisplayPolynomial();

        Console.WriteLine("Please enter the value of x: "); // Ask the user to enter the value of x.
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine();

        // calculate the value of the polynomial
        double result = 0;
        result = polynomial.EvaluatePolynomial(x);
        Console.WriteLine("The value of the polynomial is: " + result);

        // ask the user if he wants to continue
        Console.WriteLine("Do you want to continue? (yes/no)");
        string answer = Console.ReadLine();
        Console.WriteLine();

        // If yes, repeat the process
        if (answer == "yes" || answer == "Yes" || answer == "YES")
        {
            Main(args);
        }
        // If no, exit the program
        else
        {
            Console.Clear();
        }
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