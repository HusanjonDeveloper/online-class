namespace online_class.classes
{
    public class Bird : Animals
    {
        public Bird(string name, int age)
         : base(name, age)
        {

        }
        public override void Greet(string userName)
        {
            Console.WriteLine($"Hello: {userName}");
        }

        public override void Greet2(string userName)
        {
            Console.WriteLine("Brid Abstracted metod impelemented");
        }
    }
}