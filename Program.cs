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

        System.Console.WriteLine($"the difference between you and kescha's age is {kescha.AgeDifference}");

        if (age > kescha.Age)
        {
            System.Console.WriteLine("you are older!");
        }
        else if (age == kescha.Age)
        {
            System.Console.WriteLine("You are equal!");
        }
        else
        {
            System.Console.WriteLine("you are Younger!");
        }

        System.Console.WriteLine("Let me Tell you about my friends.");

        string[] friendsName = new string[3];
        friendsName[0] = "Kasee";
        friendsName[1] = "Kescha";
        friendsName[2] = name;
        int[] friendsAge = { 8, 3, age };

        for (int itaretion = 0; itaretion < friendsName.Length; itaretion++)
        {
            System.Console.WriteLine($"{friendsName[itaretion]} is {friendsAge[itaretion]} year old!");
        }
    }
}