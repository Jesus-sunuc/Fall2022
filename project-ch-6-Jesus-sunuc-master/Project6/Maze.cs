// Jesus Sunuc
// 10/12/2022
// This program is a maze solver, it will solve the maze and show the path to the exit.

namespace project6;
public class Maze
{
    // Propierties
    private char[,] map;
    // Constructor to geet and set the values, public.This means can have access.
    public char[,] Map
    {
        get { return map; }
        set { map = value; }
    }

    //The values for the entrance row
    private int rowEntrance;
    // Values for the column entrance
    private int columnEntrance;
    // Propery for the row exit
    private int rowExit;
    // Property for the exit
    private int columnExit;
    // Property fot the max range on the maze
    private int maxRow;
    // Property for the max range on the range
    private int maxColumn;

    // Constructure to get the value of the maximun row
    public int MaxRow
    {
        get { return maxRow; }
    }
    // Constructure to get the value of the maximun column
    public int MaxColumn
    {
        get { return maxColumn; }
    }
    // This is a constructor to get and set the row entranace
    public int _RowEntrance
    {
        get { return rowEntrance; }
        set { rowEntrance = value; }
    }
    // This is a constructor to get and set the column entrance
    public int _ColumnEntrance
    {
        get { return columnEntrance; }
        set { columnEntrance = value; }
    }
    // This is a constructor to get and set the row exit
    public int _RowExit
    {
        get { return rowExit; }
        set { rowExit = value; }
    }
    // This is a constructor to get and set the column exit
    public int _ColumnExit
    {
        get { return columnExit; }
        set { columnExit = value; }
    }

    // This is a method read the file.
    public Maze(StreamReader mapRows)
    {
        // Read the first row
        string valuesLines = mapRows.ReadLine();
        // Take the values on the array, and split to get the two values
        string[] storePlaceChar = valuesLines.Split(' ');
        // Parse the char, into integer, on the position 0
        maxRow = int.Parse(storePlaceChar[1]);
        // Parse the char, into integer, on the position 1
        maxColumn = int.Parse(storePlaceChar[0]);
        // Create a new map with the values, and stored for the future
        map = new char[maxRow, maxColumn];

        // Read the second row
        string entranceLine = mapRows.ReadLine();
        // Take the values on the array, and split to get the two values
        string[] storeLine2 = entranceLine.Split(' ');
        // Put the value into the rowentrance, in the position 0
        rowEntrance = int.Parse(storeLine2[0]);
        // Put the value into the ColumnEntrance, in the position 1
        columnEntrance = int.Parse(storeLine2[1]);

        // Read the third row
        string exitLine = mapRows.ReadLine();
        // Take the values on the array, and split to get the two values
        string[] storeExit = exitLine.Split(' ');
        // Put the value in the position 0 as a integer to row exit
        rowExit = int.Parse(storeExit[0]);
        // Put the value in the position 1 as an integer to the column exit.
        columnExit = int.Parse(storeExit[1]);
        // Iterates while i is less than the total number of rows
        for (int i = 0; i < maxRow; i++)
        {
            // Read the line
            string line = mapRows.ReadLine();
            // Put each elemnet on a array
            char[] charLine = line.ToCharArray();
            // Iterates while i is less than the number of columns
            for (int j = 0; j < charLine.Length; j++)
            {
                // Set the values of i and j to charLine
                map[i, j] = charLine[j];
            }
        }
    }
    // Method that return each row on the maze as a string
    public string toMazeString()
    {
        //While i and j are less than the range
        for (int i = 0; i < maxRow; i++)
        {
            for (int j = 0; j < maxColumn; j++)
            {
                //The copiler is going to read each caracter
                Console.Write(map[i, j]);
            }
            //For have all the rows, and not a pattern down
            Console.Write("\n");
        }

        return " ";
    }
    //Check if the position in map is a valid spot to move.parameters x and y
    public bool CheckedPosition(int x, int y)
    {
        //if x or y is gretaer tham the range of return false
        if (x >= maxRow || y >= maxColumn)
        {
            return false;
        }
        //if y or x are less than 0, return false
        if (y < 0 || x < 0)
        {
            return false;
        }
        //if the position of map, has a x return false
        if (map[x, y] == 'x')
        {
            return false;
        }
        //if the position of the map has a v, return false
        if (map[x, y] == 'v')
        {
            return false;
        }
        //else return true
        return true;
    }
    //This method is going to mar the position on the map, and add a * to symbol as visited
    public void markPosition(int x, int y, char change)
    {
        map[x, y] = change;
    }

}