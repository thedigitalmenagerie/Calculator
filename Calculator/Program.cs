
using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose one: *, ^, +, -, average");
            // user chooses operation to perform
            var chosenOperation = Console.ReadLine();
            Console.WriteLine("Enter three numbers to perform the chosen equation on. Be sure to seperate by commas (ie 1, 2, 3)");
            // user chooses numbers to perform operation on
            var numberSequence = Console.ReadLine();

            if (chosenOperation == "*")
            {
                //removes commas 
                var multipliedNumbers = numberSequence.Split(", ");
                // converts string to a number and multiplies all three together
                Console.WriteLine(int.Parse(multipliedNumbers[0]) * int.Parse(multipliedNumbers[1]) * int.Parse(multipliedNumbers[2]));
            } else if ( chosenOperation == "^")
            {
                var squaredNumbers = numberSequence.Split(", ");
                // squares each number (multiplying it by itself)
                Console.WriteLine(int.Parse(squaredNumbers[0]) * int.Parse(squaredNumbers[0]) + ","
                    + int.Parse(squaredNumbers[1]) * int.Parse(squaredNumbers[1]) + ","
                    + int.Parse(squaredNumbers[2]) * int.Parse(squaredNumbers[2]));
            } else if (chosenOperation == "+")
            {
                var addedNumbers = numberSequence.Split(", ");
                // adds all three numbers
                Console.WriteLine(int.Parse(addedNumbers[0]) + int.Parse(addedNumbers[1]) + int.Parse(addedNumbers[2]));
            } else if (chosenOperation == "-")
            {
                var subtractedNumbers = numberSequence.Split(", ");
                // subtracts the numbers 1-2-3
                Console.WriteLine(int.Parse(subtractedNumbers[0]) - int.Parse(subtractedNumbers[1]) - int.Parse(subtractedNumbers[2]));
            } else if (chosenOperation == "average")
            {
                var averagedNumbers = numberSequence.Split(", ");
                // adds all the numbers and divides by the amount of numbers for average
                Console.WriteLine((int.Parse(averagedNumbers[0]) + int.Parse(averagedNumbers[1]) + int.Parse(averagedNumbers[2])) / 3);
            } else
            {
                Console.WriteLine("Invalid numbers entered");
            }
        }

    }
}
