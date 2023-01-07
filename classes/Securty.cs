namespace online_class.classes
{
    public class Securty
    {
        public void checkedPassword()
        {
            string Password = "";

            do
            {
                System.Console.WriteLine("Enter Pasword: ");
                Password = Console.ReadLine();
                Console.Clear();
            } while (Password != "0");

        }
    }
}