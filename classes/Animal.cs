namespace online_class.classes
{
    class Animal
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public int AgeDifference { get; set; }

        public Animal()
        {
            Name = "No name";
            Age = 0;
            AgeDifference = 0;

        }
        public Animal(int userAge, int animalAge)
        {
            Name = "No name";
            Age = animalAge;
            AgeDifference = userAge - animalAge;
        }

    }
}