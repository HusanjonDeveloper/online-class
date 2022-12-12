using System;
using online_class.classes;
class Programm
{
    static void Main(string[] args)
    {
        Securty securty = new Securty();
        securty.checkedPassword();

        System.Console.WriteLine("Type 1st Number :");
        int fristNumber = Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine("Enter Operation (+,-,*,/,%)");
        string Operation = Console.ReadLine();

        System.Console.WriteLine("Type 2nd Number :");
        int secondNumber = Convert.ToInt32(Console.ReadLine());

        // Terner operator
        string massega =
        !(fristNumber >= 0)
        ? "1st Number Not Positive"
        : "1st Number Not Negative";
        System.Console.WriteLine(massega);

        if (fristNumber > secondNumber)
        {
            System.Console.WriteLine("1st Number is greater than 2nd Number! ");
        }
        else if (fristNumber == secondNumber)
        {
            System.Console.WriteLine("1st Number is equal to 2nd Number! ");
        }
        else
        {
            System.Console.WriteLine("1st Number is less than 2nd Number! ");
        }

        string result = Operation switch
        {
            "+" => $"{fristNumber} + {secondNumber} = {fristNumber + secondNumber}",
            "-" => $"{fristNumber} - {secondNumber} = {fristNumber - secondNumber}",
            "/" => $"{fristNumber} / {secondNumber} = {fristNumber / secondNumber}",
            "*" => $"{fristNumber} * {secondNumber} = {fristNumber * secondNumber}",
            "%" => $"{fristNumber} % {secondNumber} = {fristNumber % secondNumber}",
            _ => "Operation Not found"
        };

        System.Console.WriteLine(result);

        int counter = 2;
        while (counter < fristNumber)
        {
            System.Console.WriteLine(counter);
            counter += 2;
        }

        for (int iterator = 1; iterator <= 10; iterator++)
        {
            for (int iteratorr = 1; iteratorr <= 10; iteratorr++)
            {
                System.Console.WriteLine($"{iterator} x {iteratorr} = {iterator * iteratorr}");
            }
        }



        Console.ReadKey();
    }
}