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