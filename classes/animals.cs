namespace online_class.classes
{
    public class animals
    {


        public string name { get; set; }
        public int age { get; set; }
        public string operation { get; set; }
        public int firstNumber { get; set; }
        public int secondNumber { get; set; }

        public void IFOperation()
        {
            if (firstNumber > secondNumber)
            {
                Console.WriteLine("1st number is great tham 2nd number!");
            }
            else if (firstNumber == secondNumber)
            {
                Console.WriteLine("1st number is equal to 2nd number!");
            }
            else
            {
                Console.WriteLine("1st number is less tham 2nd number");
            }

        }
        /*
        //switch Operatori
        switch (Operation)
        {
            case "+":
                System.Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
                break;
            case "-":
                System.Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
                break;
            case "*":
                System.Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
                break;
            case "/":
                System.Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}");
                break;
            case "%":
                System.Console.WriteLine($"{firstNumber} % {secondNumber} = {firstNumber % secondNumber}");
                break;
            default:
                System.Console.WriteLine("Operation not Found");
                break;
        }
        */
        public void SwitCHOperation()
        {
            string result = operation switch
            {
                "+" => $"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}",
                "-" => $"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}",
                "/" => $"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}",
                "*" => $"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}",
                "%" => $"{firstNumber} % {secondNumber} = {firstNumber % secondNumber}",
                _ => "Operation Not found!"
            };
            System.Console.WriteLine(result);
        }
        public void IFProB()
        {
            if (firstNumber > 0)
            {
                int counter = 0;
                while (counter < firstNumber)
                {
                    System.Console.WriteLine(counter);
                    counter += 2;
                }
            }
        }
        public void ARRYOperation()
        {
            System.Console.WriteLine("Let me tell you about my friends");
            //string [] friendsName = {"vasya", "kasi", "valya"};
            string[] friendsName = new string[3];
            friendsName[0] = "Kasya";
            friendsName[1] = "Vasya";
            friendsName[2] = name;
            int[] friendsAge = { 23, 20, age };
            string[] Adress = { "Fargana", "Namangan", "Andjon" };
            for (int iteration = 0; iteration < friendsName.Length; iteration++)
            {
                System.Console.WriteLine($"{friendsName[iteration]} is {friendsAge[iteration]} year old!");
            }
            //System.Console.WriteLine($"Name_{friendsName[0]} is Age_{friendsAge[0]} year older Adress_{Adress[0]}");
            //System.Console.WriteLine($"Name_{friendsName[1]} is Age_{friendsAge[1]} year older Adress_{Adress[1]}");
            //System.Console.WriteLine($"Name_{friendsName[2]} is Age_{friendsAge[2]} year older Adress_{Adress[2]}");

            foreach (string friendName in friendsName)
            {
                System.Console.WriteLine(friendName);
            }
        }
        public void INTWHILE()
        {
            int counteri = 2;
            while (counteri < firstNumber)
            {
                System.Console.WriteLine(counteri);
                counteri += 2;
            }
        }
        public void FORWHILE()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    System.Console.WriteLine($"{i} x {j} = {i * j}");
                }
            }
        }
    }
}

