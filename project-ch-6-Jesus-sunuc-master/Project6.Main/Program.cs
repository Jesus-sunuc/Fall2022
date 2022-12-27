// Jesus Sunuc
// 10/12/2022
// This program is a maze solver, it will solve the maze and show the path to the exit.

namespace project6;
class Program
{
    // This is my maze program that allows run and call all my methods that I have on my Maza and Creature class.
    static void Main()
    {
        //Greeting
        Console.WriteLine("Welcome, this program will solve a maze for you.");
        Console.WriteLine();
        Console.WriteLine("Enter the name of the file you want to solve: ");
        Console.WriteLine();
        string fileName = Console.ReadLine();
        //Read the file named maze.txt.
        StreamReader mapRows = new StreamReader(fileName);
        //Object reference and pass the value of mapRows to maze class.
        Maze maze = new Maze(mapRows);
        //Object to send the values of the row and column pass by the maze class.
        Creature creature = new Creature(maze._RowEntrance, maze._ColumnEntrance);
        //Call the goNorth Method.
        goNorth(maze, creature);
        //To print the maze and the result.
        Console.WriteLine(maze.toMazeString());

    }

    // Method that return true of false, thata has maze, and creature as parameters.
    public static bool goNorth(Maze maze, Creature creature)
    {
        // Create a success variable
        bool success = false;
        //Statement thatt check the position and take on position on rows to select as a selection.
        if (maze.CheckedPosition(creature._positionX - 1, creature._positionY))
        {
            creature.moveNorth();
            //Mark the position method
            maze.markPosition(creature._positionX, creature._positionY, '*');

            //If there are at the position on the exit end the program
            if (maze._ColumnExit == creature._positionY && maze._RowExit == creature._positionX)
            {
                return true;
            }
            else
            {
                // Call the goNorth method
                success = goNorth(maze, creature);
                if (!success)
                {
                    //If not north, go to west
                    success = goWest(maze, creature);
                    if (!success)
                    {
                        // If not, go east
                        success = goEast(maze, creature);
                        if (!success)
                        {
                            ////Mark the position method
                            maze.markPosition(creature._positionX, creature._positionY, 'v');
                            //Move south
                            creature.moveSouth();
                        }
                    }
                }
            }
        }
        else
        {
            // Contidion of if statement
            success = false;
        }
        return success;
    }

    //This method check for south, backtraking method
    public static bool goSouth(Maze maze, Creature creature)
    {
        // Create a success variable
        bool success = false;
        //statement thatt check the position and take on position on rows to select as a selection.
        if (maze.CheckedPosition(creature._positionX + 1, creature._positionY))
        {
            creature.moveSouth();
            maze.markPosition(creature._positionX, creature._positionY, '*');
            //If there are at the position on the exit end the program
            if (maze._ColumnExit == creature._positionY && maze._RowExit == creature._positionX)
            {
                return true;
            }
            else
            {
                // Call the goNorth method
                success = goSouth(maze, creature);
                if (!success)
                {
                    //If not south, go to east
                    success = goEast(maze, creature);
                    if (!success)
                    {
                        //If not couth, go to west
                        success = goWest(maze, creature);
                        if (!success)
                        {
                            //Mark the position method
                            maze.markPosition(creature._positionX, creature._positionY, 'v');
                            //Move North
                            creature.moveNorth();
                        }
                    }
                }
            }
        }
        else
        {
            // Contidion of if statement
            success = false;
        }
        return success;
    }
    public static bool goWest(Maze maze, Creature creature)
    {
        // Create a success variable
        bool success = false;
        //Statement thatt check the position and take on position on rows to select as a selection.
        if (maze.CheckedPosition(creature._positionX, creature._positionY - 1))
        {
            creature.moveWest();
            //If there are at the position on the exit end the program
            maze.markPosition(creature._positionX, creature._positionY, '*');

            if (maze._ColumnExit == creature._positionY && maze._RowExit == creature._positionX)
            {
                return true;
            }
            else
            {
                // Call the goNorth method
                success = goWest(maze, creature);
                if (!success)
                {
                    //If no go west, go north
                    success = goNorth(maze, creature);
                    if (!success)
                    {
                        // If no go west, go south
                        success = goSouth(maze, creature);
                        if (!success)
                        {
                            //Mark the position method
                            maze.markPosition(creature._positionX, creature._positionY, 'v');
                            //Move east
                            creature.moveEast();
                        }
                    }
                }
            }
        }
        else
        {
            // Contidion of if statement
            success = false;
        }
        return success;

    }
    public static bool goEast(Maze maze, Creature creature)
    {
        // Create a success variable
        bool success = false;
        // Statement thatt check the position and take on position on rows to select as a selection.
        if (maze.CheckedPosition(creature._positionX, creature._positionY + 1))
        {
            creature.moveEast();
            maze.markPosition(creature._positionX, creature._positionY, '*');

            //If there are at the position on the exit end the program
            if (maze._ColumnExit == creature._positionY && maze._RowExit == creature._positionX)
            {
                return true;
            }
            else
            {
                // Call the goNorth method
                success = goEast(maze, creature);
                if (!success)
                {
                    //If not goEast, go North
                    success = goNorth(maze, creature);
                    if (!success)
                    {
                        //If not Go East, go goSouth
                        success = goSouth(maze, creature);
                        if (!success)
                        {
                            //Mark the position method
                            maze.markPosition(creature._positionX, creature._positionY, 'v');
                            //Move west
                            creature.moveWest();
                        }
                    }
                }
            }
        }
        else
        {
            // Contidion of if statement
            success = false;
        }
        return success;
    }
}