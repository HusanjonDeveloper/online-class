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
        string userName = Console.ReadLine();

        kescha.Greeting(userName);

        System.Console.WriteLine("Enter your age");
        string agesString = Console.ReadLine();

        System.Console.WriteLine("Converting...");

        int userAge = Convert.ToInt32(agesString);
        System.Console.WriteLine($"SECCUSSFULLY CONVERTED! {userAge}");

        Animal kescha = new Animal(name: "kescha", age: 3);

        kescha.CalculateageDifferenceWhitNoReturn(userAge);
        kescha.PrintAgeDifference();
        kescha.ConpareAges(userAge);
        kescha.TellAboutFrends(userName, userAge);
        Console.ReadKey();
    }
}