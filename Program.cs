// Kescha
using System;

using online_class.classes;

namespace online_class.classes
{
    class Programm
    {
        static void Main(string[] args)
        {
            Securty securty = new Securty();
            securty.checkedPassword();

            Animal kescha = new Bird(name: "kescha", age: 3);
            Animal Kasee = new Pet(name: "Kasee", age: 5);


            Console.WriteLine("Enter your name");
            string userName = Console.ReadLine();

            Console.WriteLine("Kescha says:");
            kescha.Greeting(userName);

            Console.WriteLine("kasee seys:");
            Kasee.Greeting(userName);


            Console.WriteLine("Enter your age");

            string agesString = Console.ReadLine();
            Console.WriteLine("Converting...");

            int userAge = Convert.ToInt32(agesString);

            Console.WriteLine($"SECCUSSFULLY CONVERTED! {userAge}");

            kescha.CalculateageDifferenceWhitNoReturn(userAge);

            kescha.PrintAgeDifference();

            kescha.ConpareAges(userAge);

            kescha.TellAboutFrends(userAge, userName);

            Console.ReadKey();
        }
    }
}