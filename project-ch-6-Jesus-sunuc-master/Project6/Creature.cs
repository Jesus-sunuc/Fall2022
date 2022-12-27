// Jesus Sunuc
// 10/12/2022
// This program is a maze solver, it will solve the maze and show the path to the exit.

public class Creature
{
    // Propertie for rows
    private int positionX;
    // Propertie for columns
    private int positionY;

    // Method and attribute to get the values as a public access.
    public int _positionX
    {
        get { return positionX; }
        set { positionY = value; }
    }
    //Method and attribute to get the values as a public access.
    public int _positionY
    {
        get { return positionY; }
        set { positionY = value; }
    }
    // Constructor to inicialate the positionX and x, also positionY to y
    public Creature(int x, int y)
    {
        positionX = x;
        positionY = y;

    }

    // Method that do not return a value, but set position to go up
    public void moveNorth()
    {
        positionX = positionX - 1;
    }
    // Method that do not return a value, but set position to go down
    public void moveSouth()
    {
        positionX = positionX + 1;
    }
    // Method that do not return a value, but set position to go right
    public void moveEast()
    {
        positionY = positionY + 1;
    }
    // Method that do not return a value, but set position to go left
    public void moveWest()
    {
        positionY = positionY - 1;
    }
}