namespace online_class.classes
{
    public class Pet : Animals
    {
        public Pet(string name, int age)
        : base(name, age)
        {

        }
        public override void Greet(string userName)
        {
            System.Console.WriteLine("Meow husan");
        }

    }
}