﻿using System;

class Programm
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Enter your name: ");
        string name = Console.ReadLine();
        string greeting = $"Hello:{name}";
        System.Console.WriteLine(greeting);
        System.Console.WriteLine("Enter your age: ");
        string ageAsString = Console.ReadLine();
        System.Console.WriteLine("Converting...");
        int age = Convert.ToInt32(ageAsString);
        System.Console.WriteLine($"Ssuccessfully converted! {age}");
        int keschasAge = 3;
        int ageDifference = age - keschasAge;
        System.Console.WriteLine($"the difference between your and kescha's age is {ageDifference}");
        if (age > keschasAge)
        {
            System.Console.WriteLine("you are older");
        }
        else if (age == keschasAge)
        {
            System.Console.WriteLine("you are equal");
        }
        else
        {
            System.Console.WriteLine("you are younger ");
        }
        System.Console.WriteLine("Let me tel about my freds");
        string[] friendsName = new string[3];
        friendsName[0] = "Kasee";
        friendsName[1] = "kescha";
        friendsName[2] = name;
        int[] friendsAge = { 20, 19, age };
        for (int i = 0; i < friendsName.Length; i++)
        {
            System.Console.WriteLine($"{friendsName[i]} is {friendsAge[i]} you are older!");
        }
    }
}