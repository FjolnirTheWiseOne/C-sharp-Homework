using System.IO;
using System;

class Program
{
    // Function for the first exercise
    static string WeatherCheck(double temp)
    {
        if (temp < 0) {
            return "Freezing Weather";
        } else if (temp >= 0 && temp < 10) {
            return "Cold";
        } else if (temp >= 10 && temp < 20) {
            return "It's getting warmer";
        } else if (temp >= 20 && temp < 30) {
            return "Now it's warm!";
        } else if (temp >= 30) {
            return "Its summer outside! Go and enjoy the weather!";
        } else {
            return "You wrote something wrong!";
        }
    }

    // Function for the second exercise
    static string AgeCheck(int age)
    {
        if (age >= 0 && age < 13) {
            return "Child";
        } else if (age >= 13 && age < 19) {
            return "Teenager";
        } else if (age >= 19) {
            return "Adult";
        } else {
            return "Not in the age range of a human! Try again";
        }
    }

    // Function for the third exercise
    static double TempConvert(double temp, string tScale)
    {
        switch (tScale) {
        case "1":
            return ((temp - 32) * 5) / 9;
        case "2":
            return (temp * 9 / 5) + 32;
        default:
            return 0; // not quite sure is this acceptable for error handling
        }
    }

    static void Main()
    {
        double result;
        Console.WriteLine("First Conditional Exercise.");
        Console.Write("Write the temperature: ");
        result = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(WeatherCheck(result)); // first exercise example

        int age;
        Console.WriteLine("Second Conditional Exercise.");
        Console.Write("Write your age: ");
        age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("You are " + AgeCheck(age)); // Second exercise example

        string tScale;
        double temp;
        Console.WriteLine("Last Conditional Exercise.");
        Console.Write("What do you want to convert? F to C, or C to F? Write 1 if the first, 2 if the other: ");
        tScale = Console.ReadLine();
        Console.Write("Write your temperature: ");
        temp = Convert.ToDouble(Console.ReadLine());
        
        double tempResult = TempConvert(temp, tScale);
        Console.WriteLine("Your converted temp is: " + tempResult); // last exercise example 
    }
}
