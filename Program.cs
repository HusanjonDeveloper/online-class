using System;
using online_class.classes;
class Programm
{
    static void Main(string[] args)
    {
        Securty securty = new Securty();
        securty.checkedPassword();

        System.Console.WriteLine("Enter your name: ");
        string name = Console.ReadLine();

        string greeting = $"Hello:{name}";
        System.Console.WriteLine(greeting);

        System.Console.WriteLine("Enter your age: ");
        string ageAsString = Console.ReadLine();
        System.Console.WriteLine("Converting...");

        int age = Convert.ToInt32(ageAsString);
        System.Console.WriteLine($"Ssuccessfully converted! {age}");

        Bird kescha = new Bird(name: "kescha", age: 3);
        Pet kasee = new Pet(name: "kasee", age: 5);
        kescha.Greet(userName: name);
        kasee.Greet(userName: name);

        System.Console.WriteLine($"kescha.Name {kescha.Name} ");
        System.Console.WriteLine($"kescha.Age {kescha.Age} ");
        kescha.CalculetAgeDifference(userAge: age);
        kescha.PrintAgeDifference();
        kescha.ComperAgs(userAge: age);
        kescha.Tellaboutfrends(userName: name, userAge: age);
        Console.ReadKey();
    }
}