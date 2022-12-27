namespace classes;
public class Polynomial // This is the Polynomial class
{
    private double[] Coefficients; // This is the array of coefficients
    private Polynomial(double[] coefficients) // This is the costructor
    {
        Coefficients = coefficients;
    }
    public static double horner(double[] coefficients, double x) // This is the horner method that returns a double value.
    {
        double result = 0; // This is the result variable.

        result = coefficients[0] * x; // This is the first step of the horner method.

        for (int i = 1; i < (coefficients.Length - 1); i++) // This is the loop that calculates the result.
        {
            result += coefficients[i]; 
            result *= x;
        }

        result += coefficients[coefficients.Length - 1];
        return result; // This is the return statement.
    }

    public static string toString(double[] coefficients) // This is the toString method that returns a string value.
    {
        string result = "";
        for (int i = 0; i < coefficients.Length; i++) // This is the loop that calculates the result.
        {
            if (coefficients[i] != 0)
            {
                result += coefficients[i] + "x^" + i + " + ";
            }
        }
        return result;
    }
}
