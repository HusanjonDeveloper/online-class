namespace online_class.classes
{
    public class Animals
    {
        public int age { get; set; }
        public int kaschasAge { get; set; }
        public string name { get; set; }

        public void IFTEACH()
        {
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
        }
        public void ARRY()
        {
            System.Console.WriteLine("Let me tell you about my friends");

            string[] friendsName = new string[3];
            friendsName[0] = "Kescha";
            friendsName[1] = "Vasya";
            friendsName[2] = name;
            int[] friendsAge = { 23, 31, age };

            System.Console.WriteLine($"{friendsName[0]} is {friendsAge[0]}");
            System.Console.WriteLine($"{friendsName[1]} is {friendsAge[1]}");
            System.Console.WriteLine($"{friendsName[2]} is {friendsAge[2]}");


            /*   
            for (int i = 1; i < friendsName.Length; i++)
            {
                System.Console.WriteLine($"{friendsName[i]} is {friendsAge[i]} your old!");
            }
            */
            foreach (string elemetnt in friendsName)
            {
                System.Console.WriteLine(elemetnt);
            }
        }
    }
}