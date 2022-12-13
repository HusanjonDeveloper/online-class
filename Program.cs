using System;
using online_class.classes;
class Programm
{
    static void Main(string[] args)
    {
        Securty securty = new Securty();
        securty.checkedPassword();

        System.Console.WriteLine("Enter your name");
        string name = Console.ReadLine();

        string greeting = $"Hello{name}";
        System.Console.WriteLine("Enter your age");
        string agesString = Console.ReadLine();

        System.Console.WriteLine("Converting...");

        int age = Convert.ToInt32(agesString);
        System.Console.WriteLine($"sECCUSSFULLY CONVERTED! {age}");

        int keschasAge = 3;

        int ageDiference = age - keschasAge;

        System.Console.WriteLine($"the difference between your and kescha's age is {ageDiference}");


        Console.ReadKey();
    }
}