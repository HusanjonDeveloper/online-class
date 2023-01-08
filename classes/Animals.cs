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
        public Animals
        (string name,
            int userAge,
        int animalAge)
        {
            Name = name;
            Age = animalAge;
            AgeDifference = userAge - animalAge;
        }
    }
}