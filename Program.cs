//Takrorlash Keschas    
using System;
using online_class.classes;

namespace online_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Securty securty = new Securty();
                securty.checkedPassword();

                Animals kescha = new Bird(name: "kescha", age: 3);
                Animals kasee = new Pet(name: "Kasee", age: 5);

                System.Console.WriteLine("Enter your Name:");
                string userName = Console.ReadLine();

                System.Console.WriteLine("kescha says");
                kescha.Greet(userName);
                System.Console.WriteLine(" kasee says");
                kasee.Greet(userName);

                System.Console.WriteLine("Enter your age: ");
                string ageAsString = Console.ReadLine();
                kasee.Greet2(userName);
                kescha.Greet2(userName);

                System.Console.WriteLine("Converting...");

                int userAge = Convert.ToInt32(ageAsString);
                System.Console.WriteLine($"Successfully converted! {userAge}");

                kescha.CalculetAgeDifferenceWithNoReturn(userAge);
                kescha.PrintageDifference();
                kescha.CompareAges(userAge);
                kescha.TellAboutFriends(userName, userAge);
            }
            catch (FormatException FormatException)
            {
                Console.WriteLine($"Erorr was thrown. Message: {FormatException.Message}");
            }
            Console.WriteLine("Program ended...");

            Console.ReadKey();
        }
    }
}