/*
Name: Jesus Sunuc
Date: 09/26/2022
Description: This program will create a date object and increment it by one day.
*/

namespace Date;
public class Date // Date class
{
    private int Day;
    private int Month;
    private int Year;

    public Date(int month, int day, int year) // Date constructor
    {
        Month = month;
        Day = day;
        Year = year;
    }
    public int GetDay() // GetDay method returns the day.
    {
        return Day;
    }

    public string GetMonth() // GetMonth method returns the month.
    {
        switch (Month)
        {
            case 1:
                return "January";
            case 2:
                return "February";
            case 3:
                return "March";
            case 4:
                return "April";
            case 5:
                return "May";
            case 6:
                return "June";
            case 7:
                return "July";
            case 8:
                return "August";
            case 9:
                return "September";
            case 10:
                return "October";
            case 11:
                return "November";
            case 12:
                return "December";
            default:
                return "Invalid Month";
        }
    }

    public int GetMonth2() // GetMonth method returns the month.
    {
        return Month;
    }

    public int GetYear() // GetYear method returns the year.
    {
        return Year;
    }

    public void ChangeDay(int day) // ChangeDay method changes the day.
    {
        Day = day;
    }

    public int ChangeMonth(int changeMonth) // ChangeMonth method changes the month.
    {
        return changeMonth;
    }

    public void ChangeYear(int year) // ChangeYear method changes the year.
    {
        Year = year;
    }

    public bool MonthOf30Days() // MonthOf30Days method returns true if the month has 30 days.
    {
        if (Month == 3 || Month == 4 || Month == 6 || Month == 9 || Month == 11)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool MonthOf31Days() // MonthOf31Days method returns true if the month has 31 days.
    {
        if (Month == 2)
        {
            return false;
        }

        if (MonthOf30Days())
        {
            return false;
        }

        return true;
    }

    public void IncrementDateByOne() // IncrementDateByOne method increments the date by one day.
    {
        if (Day <= 27)
        {
            Day++;
        }

        else if (Day == 28 && Month != 2)
        {
            Day++;
        }

        else if (Day == 28 && Month == 2)
        {
            Day = 1;
            Month = 3;
        }

        else if (Day == 29)
        {
            Day++;
        }

        else if (Day == 30 && MonthOf31Days())
        {
            Day++;
        }

        else if (Day == 30 && MonthOf30Days())
        {
            Day = 1;
            Month++;
        }

        else if (Day == 31 && MonthOf31Days())
        {
            Day = 1;
            Month++;
        }

        else if (Day == 31 && Month != 12)
        {
            Day = 1;
            Month++;
        }

        else if (Day == 31 && Month == 12)
        {
            Day = Month = 1;
            Year++;
        }
    }

    public static void Greetings() // Greetings method.
    {
        Console.WriteLine("Welcome to the date calendar!");
        Console.WriteLine("This program will create a date object and increment it by one day.");
    }
}
