namespace project3;
public class Parade // This is the Parade method.
{
    private int N;
    public Parade(int n) // Constructor
    {
        N = n;
    }
    public int getNumberOfWays() // Method
    {
        return getNumberOfWays(N);
    }
    public int getNumberOfWays(int a) // This method will show you the number of ways to organize a parade of lenght 5.
    {
        if(a == 1)
        {
            return 2;
        }
        else if(a == 2) 
        {
            return 3;
        }
        else
        {
            return getNumberOfWays(a - 1) + getNumberOfWays(a - 2);
        }
    }
}