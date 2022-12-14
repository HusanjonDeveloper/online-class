namespace online_class.classes
{
    class Animal
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