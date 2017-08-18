using static System.Console;

namespace Ch02_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            object height = 1.88;
            object name = "Amir";
            //int length1 = name.Length;
            int length2 = ((string)name).Length;
            dynamic anotherName = "Ahmed";
            int length3 = anotherName.Length;
            int population = 66_000_000;
            double weight = 1.88;
            decimal price = 4.99M;
            string fruit = "Apples";
            char letter = 'Z';
            bool happy = true;
            WriteLine($"{default(int)}");
            WriteLine($"{default(bool)}");
            WriteLine($"{ default(System.DateTime)}");
            int ICannotBeNull = 4;
            int? ICouldBeNull = null;
            WriteLine(ICouldBeNull.GetValueOrDefault());
            ICouldBeNull = 4;
            WriteLine(ICouldBeNull.GetValueOrDefault());

            string[] names = new string[4];
            names[0] = "Kate";
            names[1] = "Jack";
            names[2] = "Rebecca";
            names[3] = "Tom";
            for (int i = 0; i < names.Length; i++)
            {
                WriteLine(names[i]);
            }
            WriteLine($"The UK population is {population}.");
            Write($"The UK population is {population:N0}. ");
            WriteLine($"{weight}kg of {fruit} costs {price:C}.");

            Write("Type your first name and press ENTER: ");
            string firstName = ReadLine();
            Write("Type your age and press ENTER: ");
            string age = ReadLine();
            WriteLine($"Hello {firstName}, you look good for {age}.");
        }
    }
}