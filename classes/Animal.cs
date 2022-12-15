using System;
namespace online_class.classes
{
    public class Animal
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public int AgeDifference { get; set; }
        public Animal()
        {
            Name = "No Name";
            Age = 0;
            AgeDifference = 0;

        }
        public Animal(string name, int age)
        {
            Age = age;
            Name = name;
        }

        public Animal(
            string name,
            int userAge,
             int animalAge)
        {
            Name = "kescha";
            Age = animalAge;
            CalculateageDifferenceWhitNoReturn(userAge, animalAge);
            //AgeDifference = CalculateageDifference(userAge, animalAge);
        }
        public void PrintAgeDifference()
        {
            Console.WriteLine($"the difference between your and {Name}'s age is {AgeDifference}");

        }
        public void ConpareAges(int userAge)
        {
            if (userAge > Age)

            {
                Console.WriteLine("you are old ! ");
            }
            else if (userAge == Age)
            {
                Console.WriteLine("you are equal !");
            }
            else
            {
                Console.WriteLine("you are yourger !");
            }

        }
        public void TellAboutFrends(int userAge, string userName)
        {
            Console.WriteLine("Let me Tell about my friends");

            string[] friendsName = new string[3];
            friendsName[0] = "Kescha";
            friendsName[1] = "Vasya";
            friendsName[2] = userName;
            int[] friendsAge = { 17, 15, userAge };

            for (int i = 0; i < friendsName.Length; i++)
            {
                Console.WriteLine($"{friendsName[i]} is {friendsAge[i]} year old !");
            }
        }

        public int CalculateageDifferenceWhitNoReturn(int userAge)
        {
            return userAge - Age;
        }
        public void Greeting(string userName)
        {
            Console.WriteLine($"Hello {userName}");
            if (userName == "")
            {
                userName = "Onknown Person";
            }
        }
        private int CalculateageDifference(int userAge, int animalAge)
        {
            return userAge - animalAge;
        }
        private void CalculateageDifferenceWhitNoReturn(int userAge, int animalAge)
        {
            AgeDifference = userAge - animalAge;
        }

    }
}