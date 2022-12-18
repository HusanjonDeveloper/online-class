// Kescha
using System;

using online_class.classes;

namespace online_class.classes
{
    class Programm
    {
        static void Main(string[] args)
        {
            try
            {
                Securty securty = new Securty();
                securty.checkedPassword();

                Animal Kescha = new Bird(name: "kescha", age: 10);
                Animal Kasee = new Pet(name: "Kasee", age: 8);

                Console.WriteLine("Kescha was creted:" + Kescha.DataTime);
                Console.WriteLine("Kasee was creted:" + Kasee.DataTime);

                Console.WriteLine("Enter your name");
                string userName = Console.ReadLine();

                Console.WriteLine("Kescha says:");
                Kescha.Greeting(userName);

                Console.WriteLine("kasee seys:");
                Kasee.Greeting(userName);


                Console.WriteLine("Enter your age");

                string agesString = Console.ReadLine();

                Kasee.Greet2(userName);

                Console.WriteLine("Converting...");

                int userAge = Convert.ToInt32(agesString);

                Console.WriteLine($"SECCUSSFULLY CONVERTED! {userAge}");

                Kescha.CalculateageDifferenceWhitNoReturn(userAge);

                Kescha.PrintAgeDifference(userAge, kescha: 10);

                Kescha.AnimalsMullte(kescha: 10, kasee: 8);

                Kescha.ConpareAges(userAge);

                Kescha.TellAboutFrends(userAge, userName);

                Console.ReadKey();

            }
            catch (FormatException FormatException)
            {
                Console.WriteLine($"Error was thrown. Message:{FormatException.Message}");
            }
            Console.WriteLine("Program ended...");


        }
    }
}