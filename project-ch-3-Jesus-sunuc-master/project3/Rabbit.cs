namespace project3;
public class Rabbit // This is the Rabbit method.
{
    private int R;
    public Rabbit(int r) // Constructor
    {
        R = r;
    }
    public int rabbits()
    {
        return rabbits(R);
    }
    public int rabbits(int r) // This method will show you the pair of rabbits depending the month.
    {
        if(r == 1)
        {
            return 2;
        }
        else if(r == 2) 
        {
            return 3;
        }
        else
        {
            return rabbits(r - 1) + rabbits(r - 2);
        }
    }
}