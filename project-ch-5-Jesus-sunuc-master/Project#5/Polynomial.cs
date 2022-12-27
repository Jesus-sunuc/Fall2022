
namespace classes;
using System.Collections.Generic;

public class Polynomial // This is the Polynomial class
{
    private Node head; // This is the head of the linked list.

    public Polynomial() // This is the constructor.
    {
        head = null!;
    }

    public void AddTerm(double coefficient, int exponent) // This is the AddTerm method.
    {
        Node newNode = new Node(coefficient, exponent); // This is the object of the Node class.

        if (head == null) // If the head is null, then the new node is the head. 
        {
            head = newNode; // Set the head to the new node.
        }
        else
        {
            Node current = head; // This is the current node.
            while (current.Next != null) // While the next node is not null, then the current node is the next node.
            {
                current = current.Next; // Set the current node to the next node.
            }
            current.Next = newNode; // Set the next node to the new node.
        }
    }

    public void DisplayPolynomial() // This is the DisplayPolynomial method.
    {
        Node current = head; // This is the current node.
        while (current != null) // While the current node is not null, then display the current node.
        {
            Console.Write(current.ToString() + " + ");//display the coefficient and the exponent of the polynomial
            current = current.Next;//move to the next node
        }

        Console.WriteLine();
    }

    public double EvaluatePolynomial(double x) // This is the EvaluatePolynomial method.
    {
        double result = 0; // This is the result of the polynomial.
        Node current = head; // This is the current node.
        while (current != null) // While the current node is not null, then calculate the result of the polynomial.
        {
            result += current.Coefficient * Math.Pow(x, current.Exponent); // Calculate the result of the polynomial.
            current = current.Next; // Move to the next node.
        }


        return result; // Return the result of the polynomial.
    }

    public override string ToString() // This is the ToString method.
    {
        string result = ""; // This is the result of the polynomial.
        Node current = head; // This is the current node.
        while (current != null) // While the current node is not null, then calculate the result of the polynomial.
        {
            result += current.ToString() + " + "; // Calculate the result of the polynomial.
            current = current.Next; // Move to the next node.
        }

        return result;//return the result string
    }
}