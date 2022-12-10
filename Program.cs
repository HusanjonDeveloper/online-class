using System;
using online_class.classes;
class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("int Kescha");

        Securty securty = new Securty();
        securty.checkedPassword();

        System.Console.WriteLine("Enter your name");
        string name = Console.ReadLine();

        System.Console.WriteLine("Enter your Age");
        int age = Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine("Enter 1st number");
        int firstNumber = Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine("Enter Operation(+,-,*,/,%)");
        string operation = Console.ReadLine();

        System.Console.WriteLine("Enter 2nd Number");
        int secondNumber = Convert.ToInt32(Console.ReadLine());

        // terner operator 
        string message =
        !(firstNumber >= 0)
        ? "1st number is not positive"
         : "1st number is not negative";
        // logical operator:&&,||, 
        System.Console.WriteLine(message);
        // if Operatori
        animals animals = new animals();
        animals.IFOperation();

        // switch Expression
        animals.SwitCHOperation();
        // loop - tsikl - Aylanma
        animals.IFProB();
        //Arrey
        animals.ARRYOperation();

        animals.INTWHILE();

        animals.FORWHILE();
    }


}