namespace project3;
public class Job // This is the Job method.
{
    private int D;
    public Job(int d) // Constructor
    {
        D = d;
    }
    public int multiplyByTwo()
    {
        return multiplyByTwo(D);
    }

    public int multiplyByTwo(int d) // This method will show you the amount of money per day between 1 to 30.
    {
        if(d == 1)
        {
            return 1;
        }
        else if (d > 1 && d <= 30) {
            return multiplyByTwo(d - 1) * 2;
        }
        else
        {
            return 0;
        }
    }
}