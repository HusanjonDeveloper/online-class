using System;
using online_class.classes;

System.Console.WriteLine("Int oop");

Securty seecurty = new Securty();
seecurty.checkedPassword();

System.Console.WriteLine("Enter yuour name");
string name = Console.ReadLine();

string greeting = $"Hello{name}";
System.Console.WriteLine(greeting);

System.Console.WriteLine("Enter your Age");
string ageAsString = Console.ReadLine();
System.Console.WriteLine("Converting...");

int age = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Successtully converting {age}");

Animals Kescha = new Animals();

int kaschasAge = 3;

int ageDifference = age - kaschasAge;

System.Console.WriteLine($"The difference between your and kescha's age is{ageDifference}");

if (age > kaschasAge)
{
    System.Console.WriteLine("you are older!");
}
else if (age == kaschasAge)
{
    System.Console.WriteLine("you are equal!");
}
else
{
    System.Console.WriteLine("you are younger!");
}
System.Console.WriteLine("Let me tell you about my friends");

string[] friendsName = new string[3];
friendsName[0] = "Kescha";
friendsName[1] = "Vasya";
friendsName[2] = name;
int[] friendsAge = { 23, 31, age };
for (int i = 0; i < friendsName.Length; i++)
{
    System.Console.WriteLine($"{friendsName[i]} is {friendsAge[i]} your old!");
}
