/*
Jesus Sunuc
Project #1
02-08-2022
*/

namespace Chapter1;

public class Program
{
    public static void Main()
    {
        Console.Clear();
        Console.WriteLine("This program will store your academic records. Create a 'Student Object'");
        Console.WriteLine("\nPlease enter your name, and ID");
        Console.WriteLine();
        Student student = new Student(Console.ReadLine(), Console.ReadLine());
        Console.WriteLine("\nPlease the number of Credits");
        student.SetCredits(Console.ReadLine());

        Console.WriteLine("\nPlease enter the total Points earned");
        student.SetGradePoints(Console.ReadLine());

        Console.WriteLine($"\nYour GPA is {student.GetGPA().ToString()}!");
        Console.WriteLine("\nPress '1' to see your credits, press '2' to see your points, press '3' to see your name, press '4' to see your ID, to exit the program press '5'");

        Console.WriteLine();

        //ConsoleKey Key = Console.ReadKey(true).Key;

        switch (Console.ReadKey(true).Key)
        {
            case ConsoleKey.D1:
                Console.WriteLine(student.GetCredits());
                break;

            case ConsoleKey.D2:
                Console.WriteLine(student.GetGradePoints());
                break;

            case ConsoleKey.D3:
                Console.WriteLine(student.GetName());
                break;

            case ConsoleKey.D4:
                Console.WriteLine(student.GetID());

                break;

            case ConsoleKey.D5:
                System.Environment.Exit(0);
                break;

            default:
                break;
        }
    }
}
