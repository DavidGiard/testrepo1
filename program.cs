using System;
using TestRepo1;

decimal firstNumber = ReadNumber("Enter the first number: ");
decimal secondNumber = ReadNumber("Enter the second number: ");

Console.WriteLine($"The sum is: {Calculator.Add(firstNumber, secondNumber)}");

static decimal ReadNumber(string prompt)
{
    while (true)
    {
        Console.Write(prompt);

        if (decimal.TryParse(Console.ReadLine(), out decimal number))
        {
            return number;
        }

        Console.WriteLine("Please enter a valid number.");
    }
}
