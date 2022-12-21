//Takrorlash Keschas    
using System;
using online_class.classes;

class Programm
{
    static void Main(string[] args)
    {
        Securty securty = new Securty();
        securty.checkedPassword();

        System.Console.WriteLine("Enter your Name:");
        string name = Console.ReadLine();

        string greeting = $"Hello: {name}";
        System.Console.WriteLine(greeting);

        System.Console.WriteLine("Enter your age: ");
        string ageAsString = Console.ReadLine();

        System.Console.WriteLine("Converting...");

        int age = Convert.ToInt32(ageAsString);
        System.Console.WriteLine($"Successfully converted! {age}");

        Animals kescha = new Animals(name: "kescha", userAge: age, animalAge: 3);

        kescha.Age = 3;

        kescha.PrintageDifference();
        kescha.CompareAges(userAge: age);
        kescha.TellAboutFriends(userName: name, userAge: age);


    }
}