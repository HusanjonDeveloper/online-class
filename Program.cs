//Takrorlash Keschas    
using System;
using online_class.classes;

namespace online_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Securty securty = new Securty();
            securty.checkedPassword();

            Animals kescha = new Animals(name: "kescha", age: 3);

            System.Console.WriteLine("Enter your Name:");
            string userName = Console.ReadLine();

            kescha.Greet(userName);

            System.Console.WriteLine("Enter your age: ");
            string ageAsString = Console.ReadLine();

            System.Console.WriteLine("Converting...");

            int userAge = Convert.ToInt32(ageAsString);
            System.Console.WriteLine($"Successfully converted! {userAge}");

            kescha.CalculetAgeDifferenceWithNoReturn(userAge);
            kescha.PrintageDifference();
            kescha.CompareAges(userAge);
            kescha.TellAboutFriends(userName, userAge);
            Console.ReadKey();
        }
    }
}