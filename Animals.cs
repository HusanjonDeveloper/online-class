namespace online_class.classes
{
    public class Animals
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public int AgeDifference { get; set; }


        public Animals()
        {
            Name = "No name";
            Age = 0;
            AgeDifference = 0;
        }

        public Animals(
            string name,
            int userAge,
            int animalAge)
        {
            Name = name;
            Age = animalAge;
            CalculetAgeDifferenceWithNoReturn(userAge, animalAge);
            // AgeDifference = CalculetAgeDifference(userAge, animalAge);
        }
        public void PrintageDifference()
        {
            Console.WriteLine($"the difference between you and {Name}'s age is {AgeDifference}");

        }
        public void CompareAges(int userAge)
        {
            if (userAge > Age)
            {
                Console.WriteLine("you are older!");
            }
            else if (userAge == Age)
            {
                Console.WriteLine("You are equal!");
            }
            else
            {
                Console.WriteLine("you are Younger!");
            }
        }
        public void TellAboutFriends(string userName, int userAge)
        {

            Console.WriteLine("Let me Tell you about my friends.");

            string[] friendsName = new string[3];
            friendsName[0] = "Kasee";
            friendsName[1] = "Kescha";
            friendsName[2] = userName;
            int[] friendsAge = { 8, 3, userAge };

            for (int itaretion = 0; itaretion < friendsName.Length; itaretion++)
            {
                Console.WriteLine($"{friendsName[itaretion]} is {friendsAge[itaretion]} year old!");
            }
        }
        private int CalculetAgeDifference(int userAge, int animalAge)
        {
            return userAge - animalAge;
        }
        private void CalculetAgeDifferenceWithNoReturn(int userAge, int animalAge)
        {
            AgeDifference = userAge - animalAge;
        }


    }
}