namespace online_class.classes
{
    public class Pet : Animal
    {
        public PetType Type { get; set; }
        public Pet(string name, int age)
        : base(name, age)
        {

        }

        public override void Greeting(string userName)
        {
            Console.WriteLine($" MEOW, {userName}");
        }

        public override void Greet2(string userName)
        {
            Console.WriteLine("Abstracted metod implamets");
        }
    }
}