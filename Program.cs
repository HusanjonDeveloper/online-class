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
        System.Console.WriteLine($"sECCUSSFULLY CONVERTED! {age}");

        Animal kescha = new Animal();
        kescha.Age = 3;

        int ageDiference = age - kescha.Age;

        System.Console.WriteLine($"the difference between your and kescha's age is {ageDiference}");

        if (age > kescha.Age)

        {
            System.Console.WriteLine("you are old ! ");
        }
        else if (age == kescha.Age)
        {
            System.Console.WriteLine("you are equal !");
        }
        else
        {
            System.Console.WriteLine("you are yourger !");
        }

        System.Console.WriteLine("Let me Tell about my friends");

        string[] friendsName = new string[3];
        friendsName[0] = "Kescha";
        friendsName[1] = "Vasya";
        friendsName[2] = name;
        int[] friendsAge = { 17, 15, age };

        for (int i = 0; i < friendsName.Length; i++)
        {
            System.Console.WriteLine($"{friendsName[i]} is {friendsAge[i]} year old !");
        }
        Console.ReadKey();
    }
}