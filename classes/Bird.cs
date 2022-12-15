using System;
namespace online_class.classes
{
    public class Bird : Animal
    {
        public Bird(string name, int age)
        : base(name, age)
        {

        }
        public override void Greeting(string userName)
        {
            Console.WriteLine($"Hello,{userName}");
        }

    }
}