/*
Name: Jesus Sunuc
Date: 09/26/2022
Description: This program will create a date object and increment it by one day.
*/

namespace Date;
class Program
{
    public static void Main() // Main method.
    {
        Date.Greetings(); // Call the greetings method.
        Console.WriteLine("Choose an option:");
        Console.WriteLine("1. It will show you the date in this format: MM/DD/YYYY (e.g. April/01/2021)");
        Console.WriteLine("2. It will show you the date in this format: MM/DD/YYYY (e.g. 04/01/2021)");
        Console.WriteLine("3. Enter the month, day, and year you want to replace it with, and it will show you the the date incremented by one day.");
        Console.WriteLine("4. Exit");
        Console.WriteLine();

        string x = Console.ReadLine();
        int intputValue = int.Parse(x);

        switch (intputValue) // Switch statement.
        {
            case 1: // Case 1.
                Console.WriteLine();
                Console.WriteLine("Enter the month represented by a number (e.g. 1 for January, 2 for February, etc.):");
                string val1 = Console.ReadLine();
                int value1 = int.Parse(val1);
                Console.WriteLine("Enter the day (e.g. 1, 2, 3, etc.):");
                string val2 = Console.ReadLine();
                int value2 = int.Parse(val2);
                Console.WriteLine("Enter the year (e.g. 2021, 2022, etc.):");
                string val3 = Console.ReadLine();
                int value3 = int.Parse(val3);
                Date date1 = new Date(value1, value2, value3); // Create a date object.
                Console.WriteLine("The date is: " + date1.GetMonth() + " " + date1.GetDay() + ", " + date1.GetYear()); // Display the date.
                break;

            case 2: // Case 2.
                Console.WriteLine();
                Console.WriteLine("Enter the month represented by a number (e.g. 1, 2, 3, etc):");
                string val4 = Console.ReadLine();
                int value4 = int.Parse(val4);
                Console.WriteLine("Enter the day (e.g. 1, 2, 3, etc.):");
                string val5 = Console.ReadLine();
                int value5 = int.Parse(val5);
                Console.WriteLine("Enter the year (e.g. 2021, 2022, etc.):");
                string val6 = Console.ReadLine();
                int value6 = int.Parse(val6);
                Date date2 = new Date(value4, value5, value6); // Create a date object.
                Console.WriteLine("The date is: " + date2.GetMonth2() + "/" + date2.GetDay() + "/" + date2.GetYear()); // Display the date.
                break;

            case 3: // Case 3.
                Console.WriteLine();
                Console.WriteLine("Enter the month represented by its name (e.g. 1 for January, 2 for February, etc.):");
                string val7 = Console.ReadLine();
                int value7 = int.Parse(val7);
                Console.WriteLine("Enter the day (e.g. 1, 2, 3, etc.):");
                string val8 = Console.ReadLine();
                int value8 = int.Parse(val8);
                Console.WriteLine("Enter the year (e.g. 2021, 2022, etc.):");
                string val9 = Console.ReadLine();
                int value9 = int.Parse(val9);
                Date date3 = new Date(value7, value8, value9); // Create a date object.

                Console.Write("The change date is: ");
                date3.ChangeMonth(value7); // Change the month.
                date3.ChangeDay(value8); // Change the day.
                date3.ChangeYear(value9); // Change the year.

                for (int i = 0; i <= 31; i++) // Increment the date by one day.
                {
                    date3.IncrementDateByOne();
                    Console.WriteLine(date3.GetMonth() + "/" + date3.GetDay() + "/" + date3.GetYear());
                }
                break;

            case 4: // Case 4.
                Console.Clear();
                break;
        }
    }
}
