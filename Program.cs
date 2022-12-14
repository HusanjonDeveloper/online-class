// Kescha
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
        System.Console.WriteLine($"SECCUSSFULLY CONVERTED! {age}");

        Animal kescha = new Animal(name: "kescha", userAge: age, animalAge: 3);
        kescha.Age = 3;

        System.Console.WriteLine(kescha.Name);
        System.Console.WriteLine(kescha.Age);


        kescha.PrintAgeDifference();
        kescha.ConpareAges(userAge: age);
        kescha.TellAboutFrends(userName: name, userAge: age);
        Console.ReadKey();
    }
}