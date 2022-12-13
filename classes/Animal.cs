namespace online_class.classes
{
    class Animal
    {
        private int age;

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value > 0)

                {
                    age = value;

                }
            }

        }

    }
}