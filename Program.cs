//Takrorlash Keschas    
using System;
using online_class.classes;
using online_class.Enums;

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

                Bird kescha = new Bird(name: "kescha", age: 3);
                Pet kasee = new Pet(name: "Kasee", age: 5);

                kasee.Type = PetType.Cat;
                kescha.Types = BridType.Dog;


                System.Console.WriteLine("kescha was created:" + kescha.CreatedDate);
                System.Console.WriteLine("kasee was created:" + kasee.CreatedDate);
                System.Console.WriteLine(kasee.Type);
                System.Console.WriteLine(kescha.Types);

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
            catch (Exception Exception)
            {
                System.Console.WriteLine("Erorr was thrown. Type is Not know.");
            }
            Console.WriteLine("Program ended...");

            Console.ReadKey();
        }
    }
}