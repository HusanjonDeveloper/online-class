namespace online_class.classes
{
    public class Animals
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public int AgeDifference { get; set; }
        public Animals()
        {
            Name = " No name";
            Age = 0;
            AgeDifference = 0;

        }
        public Animals(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public Animals
        (string name,
            int userAge,
        int animalAge)
        {
            Name = name;
            Age = animalAge;
            AgeDifference = CalculetAgeDifference(userAge, animalAge);
        }

        public void PrintAgeDifference()
        {
            Console.WriteLine($"the difference between your and {Name}'s age is {AgeDifference}");

        }
        public void ComperAgs(int userAge)
        {
            if (userAge > Age)
            {
                Console.WriteLine("you are older");
            }
            else if (userAge == Age)
            {
                Console.WriteLine("you are equal");
            }
            else
            {
                Console.WriteLine("you are younger ");
            }
        }
        public void Tellaboutfrends(string userName, int userAge)
        {

            System.Console.WriteLine("Let me tel about my freds");

            string[] friendsName = new string[3];
            friendsName[0] = "Kasee";
            friendsName[1] = "kescha";
            friendsName[2] = userName;
            int[] friendsAge = { 20, 19, userAge };

            for (int i = 0; i < friendsName.Length; i++)
            {
                System.Console.WriteLine($"{friendsName[i]} is {friendsAge[i]} you are older!");
            }
        }
        public virtual void Greet(string userName)
        {
            if (userName == "")
            {
                userName = "Unknown Person";
            }
        }
        public int CalculetAgeDifference(int userAge)
        {
            return userAge - Age;

        }
        public int CalculetAgeDifference(int userAge, int animalAge)
        {
            return userAge - animalAge;

        }
        private void CalculetAgeDifferenceWithNoReturn(int animalAge, int userAge)
        {
            AgeDifference = userAge - animalAge;
        }
    }
}