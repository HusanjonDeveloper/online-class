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
        string userName = Console.ReadLine();

        string greeting = $"Hello: {userName}";
        System.Console.WriteLine(greeting);

        System.Console.WriteLine("Enter your age: ");
        string ageAsString = Console.ReadLine();

        System.Console.WriteLine("Converting...");

        int userAge = Convert.ToInt32(ageAsString);
        System.Console.WriteLine($"Successfully converted! {userAge}");

        Animals kescha = new Animals(name: "kescha", age: 3);

        kescha.CalculetAgeDifferenceWithNoReturn(userAge);
        kescha.PrintageDifference();
        kescha.CompareAges(userAge);
        kescha.TellAboutFriends(userName, userAge);


    }
}