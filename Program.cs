using System;
using online_class.classes;
class Program
{

    static void Main(string[] args)
    {

        System.Console.WriteLine("Int oop");

        Securty seecurty = new Securty();
        seecurty.checkedPassword();

        System.Console.WriteLine("Enter yuour name");
        string name = Console.ReadLine();

        string greeting = $"Hello{name}";
        System.Console.WriteLine(greeting);

        System.Console.WriteLine("Enter your Age");
        string ageAsString = Console.ReadLine();
        System.Console.WriteLine("Converting...");

        int age = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine($"Successtully converting {age}");



        int kaschasAge = 3;

        int ageDifference = age - kaschasAge;

        System.Console.WriteLine($"The difference between your and kescha's age is{ageDifference}");

        Animals animals = new Animals();

        animals.IFTEACH();


        Console.ReadKey();
    }
}
