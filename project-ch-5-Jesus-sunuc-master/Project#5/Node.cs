namespace classes;
using System.Collections.Generic;

public class Node // This is the Node class
{
    public double Coefficient { get; set; } // This is the coefficient of the polynomial.
    public double Exponent { get; set; } // This is the exponent of the polynomial.
    public Node Next { get; set; } // This is the next node.
    
    public Node(double coefficient, double exponent) // This is the constructor.
    {
        Coefficient = coefficient; // Set the coefficient to the coefficient of the polynomial.
        Exponent = exponent; // Set the exponent to the exponent of the polynomial.
        Next = null!;
    }
    
    public override string ToString() // This is the ToString method.
    {
        return Coefficient + "x^" + Exponent; //Return the coefficient and the exponent of the polynomial
    }
}