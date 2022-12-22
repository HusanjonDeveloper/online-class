
using online_class.Enums;

namespace online_class.classes
{
    public class Pet : Animals, IAnimal
    {
        public PetType Type { get; set; }
        public Pet(string name, int age)
         : base(name, age)
        {

        }
        public override void Greet(string userName)
        {
            Console.WriteLine($"Meow. {userName}");
        }

        public override void Greet2(string userName)
        {
            Console.WriteLine(" Pet Abstracted metod impelemented");
        }
    }
}