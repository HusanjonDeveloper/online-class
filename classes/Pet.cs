using System;
namespace online_class.classes
{
    public class Pet : Animal
    {
        public Pet(string name, int age)
        : base(name, age)
        {

        }
        public override void Greeting(string userName)
        {
            Console.WriteLine($" MEOW, {userName}");
        }
    }
}