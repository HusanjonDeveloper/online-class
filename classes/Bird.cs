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
            System.Console.WriteLine($"hello {userName}");
        }

    }
}