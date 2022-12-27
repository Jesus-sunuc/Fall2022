/*
Name: Jesus Sunuc
Date: 09/20/2022
Description: This program will show you four options, all of them have different functions.
*/

namespace project3;
class Program
{
    public static void Main()
    {
        // Greetings
        Console.WriteLine("Choose an option:");
        Console.WriteLine("1. Organize parade for input 5.");
        Console.WriteLine("2. Day money calculations.");
        Console.WriteLine("3. Multiplying Rabbits");
        Console.WriteLine("4. Exit");
        // Let the user enter a number from 1 to 4 to choose an option.
        string x = Console.ReadLine();
        int intputValue = int.Parse(x);

        switch (intputValue) // Switch statement that allows the user enter a value.
        {
            case 1: // We have case one to be used. This allows the user to see the result for a number 5 that has been determined by the program.
                Console.WriteLine();
                Console.WriteLine("This program will show you the number of ways to organize a parade of lenght 5.");
                int n = 5;
                Parade parade = new Parade(n);
                Console.Write("The number of ways to organize a parade of lenght " + n + " is: ");
                Console.Write(parade.getNumberOfWays());
                Console.WriteLine();
                break;

            case 2: // We have case two to be used. This allows the user to enter a number between 1 to 30.
                Console.WriteLine();
                Console.WriteLine("This program will show you the amount of money per day. Please enter a number from 1 to 30.");
                string val = Console.ReadLine();
                int value = int.Parse(val);
                Job job = new Job(value);
                Console.WriteLine("The day number is " + value + " and the amount of money paid that day is: ");
                Console.WriteLine("$" + job.multiplyByTwo() + " cent/s");
                break;

            case 3: // We have case three to be used. This allows the user to enter a number that represents that a month.
                Console.WriteLine();
                Console.WriteLine("This program will show you the pair of rabbits depending the month, please enter a number.");
                string input = Console.ReadLine();
                int valInput = int.Parse(input);
                Rabbit rabbit = new Rabbit(valInput);
                Console.WriteLine(valInput + " months and these are the pairs of rabbits " + rabbit.rabbits());
                break;

            case 4: // We have case four to be used. This quits the program.
                Console.Clear();
                break;
        }
    }
}